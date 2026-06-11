using System;

class BankAccount {
    private double balance;

    // Initial balance Method
    public BankAccount(double initialBalance) {
        balance = initialBalance;
    }

    //deposite Method
    public void deposite(double amount) {
        if ( amount > 0) {
            balance += amount;
            Console.WriteLine("Amount deposited successfully");
            Console.WriteLine($"Deposite amount : {amount}, Current balance : {balance}");
        } else {
            Console.WriteLine("You cannot deposite negative amount");
        }
    }

    //withdraw Method
    public void withdraw(double amount) {
        if (amount > 0 && amount <= balance) {
            balance -= amount;
            Console.WriteLine("Amount withdrawn successfully");
            Console.WriteLine($"Withdraw amount : {amount}, Current balance : {balance}");
        } else {
            Console.WriteLine("Invalid withdrawal amount");
        }
    }
    
    //balance check Method
    public double balanceCheck() {
        return balance;
    }
}
