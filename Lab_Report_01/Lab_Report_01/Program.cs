using System;
class Program {
    public static void Main(string[] args)
    {
        // create account with initial balance
        BankAccount account = new BankAccount(1000);
        // deposit money
        account.deposite(500); 
        Console.WriteLine("");
        // withdraw money
        account.withdraw(200);
        Console.WriteLine("");
        // invalid withdrawal
        account.withdraw(2000); 
        Console.WriteLine("");
        // check balance     
        Console.WriteLine($"Current balance: {account.balanceCheck()}");
    }
}