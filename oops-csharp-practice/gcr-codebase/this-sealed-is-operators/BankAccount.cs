using System;

class BankAccount
{
    public static string bankName = "MyBank";
    private static int totalAccounts = 0;

    public readonly int AccountNumber;
    public string AccountHolderName;

    public BankAccount(string AccountHolderName, int AccountNumber)
    {
        this.AccountHolderName = AccountHolderName;
        this.AccountNumber = AccountNumber;
        totalAccounts++;
    }

    public void DisplayDetails()
    {
        if (this is BankAccount)
        {
            Console.WriteLine("Bank: " + bankName);
            Console.WriteLine("Account Holder: " + AccountHolderName);
            Console.WriteLine("Account Number: " + AccountNumber);
        }
    }

    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts: " + totalAccounts);
    }

    static void Main()
    {
        BankAccount a1 = new BankAccount("Gaurav", 101);
        BankAccount a2 = new BankAccount("Amit", 102);

        a1.DisplayDetails();
        Console.WriteLine();
        a2.DisplayDetails();
        Console.WriteLine();

        BankAccount.GetTotalAccounts();
    }
}
