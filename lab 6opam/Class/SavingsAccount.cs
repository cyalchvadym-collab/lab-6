// BankAccounts/SavingsAccount.cs
namespace lab6.BankAccounts;

public class SavingsAccount : Account
{
    public decimal InterestRate { get; set; }
    public int WithdrawalLimit { get; set; } = 3;
    public int WithdrawalsThisMonth { get; private set; }

    public SavingsAccount(string number, string owner, decimal balance, decimal rate = 0.05m)
        : base(number, owner, balance)
    {
        InterestRate = rate;
    }

    public override bool Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > Balance)
        {
            Console.WriteLine("❌ Недостатньо коштів");
            return false;
        }

        decimal commission = 0;
        if (WithdrawalsThisMonth >= WithdrawalLimit)
        {
            commission = amount * 0.02m;
            Console.WriteLine($"⚠️ Комісія 2%: {commission:C}");
        }

        Balance -= amount + commission;
        WithdrawalsThisMonth++;
        Console.WriteLine($"💸 -{amount:C} | Баланс: {Balance:C}");
        return true;
    }

    public void ApplyInterest()
    {
        decimal interest = Balance * InterestRate;
        Balance += interest;
        Console.WriteLine($"📈 Відсотки: +{interest:C}");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"   [Ощадний] Ставка: {InterestRate:P}, Знять: {WithdrawalsThisMonth}/{WithdrawalLimit}");
    }
}