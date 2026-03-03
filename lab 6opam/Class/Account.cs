// BankAccounts/Account.cs
namespace lab6.BankAccounts;

public abstract class Account
{
    public string AccountNumber { get; set; }
    public string OwnerName { get; set; }
    public decimal Balance { get; protected set; }
    
    public Account(string number, string owner, decimal balance)
    {
        AccountNumber = number;
        OwnerName = owner;
        Balance = balance;
    }
    
    public abstract bool Withdraw(decimal amount);
    
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"💰 +{amount:C} | Баланс: {Balance:C}");
        }
    }
    
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"📋 {AccountNumber} | {OwnerName} | {Balance:C}");
    }
}