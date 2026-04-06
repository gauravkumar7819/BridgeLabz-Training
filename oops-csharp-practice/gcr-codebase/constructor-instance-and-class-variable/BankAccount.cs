using System;

public class BankAccount
{
    public int accountNumber;
    protected string accountHolder;
    private double balance;

    public BankAccount(int accountNumber, string accountHolder, double balance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public double GetBalance()
    {
        return balance;
    }

    static void Main()
    {
        SavingsAccount sa = new SavingsAccount(101, "Gaurav Kumar", 5000);

        sa.DisplayDetails();
        sa.Deposit(2000);

        Console.WriteLine("Current Balance: " + sa.GetBalance());
    }
}

public class SavingsAccount : BankAccount
{
    public SavingsAccount(int accountNumber, string accountHolder, double balance)
        : base(accountNumber, accountHolder, balance)
    {
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolder);
    }
}
