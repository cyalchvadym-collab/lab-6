// BankAccounts/BusinessAccount.cs
namespace lab6.BankAccounts;

public class BusinessAccount : Account
{
    public string CompanyName { get; set; }
    public decimal OverdraftLimit { get; set; }
    private const decimal MonthlyFee = 50m;

    public BusinessAccount(string number, string owner, decimal balance, string company, decimal overdraft = 10000m)
        : base(number, owner, balance)
    {
        CompanyName = company;
        OverdraftLimit = overdraft;
    }

    public override bool Withdraw(decimal amount)
    {
        if (amount <= 0) return false;

        decimal available = Balance + OverdraftLimit;
        if (amount > available)
        {
            Console.WriteLine("❌ Перевищено ліміт (з овердрафтом)");
            return false;
        }

        decimal commission = 0;
        if (amount > Balance)
        {
            decimal overdraft = amount - Balance;
            commission = overdraft * 0.05m;
            Console.WriteLine($"⚠️ Овердрафт {overdraft:C}, комісія 5%: {commission:C}");
        }
        else
        {
            commission = amount * 0.01m;
            Console.WriteLine($"⚠️ Комісія 1%: {commission:C}");
        }

        Balance -= amount + commission;
        Console.WriteLine($"💸 -{amount:C} | Баланс: {Balance:C}");
        return true;
    }

    public void ChargeMonthlyFee()
    {
        if (Balance >= MonthlyFee)
        {
            Balance -= MonthlyFee;
            Console.WriteLine($"💳 Комісія: -{MonthlyFee:C}");
        }
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"   [Бізнес] {CompanyName}, Овердрафт: {OverdraftLimit:C}");
    }
}