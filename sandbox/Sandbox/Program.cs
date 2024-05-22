using System;

class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();
        // Under a public string, the following line could use bank.balance and see/change that directly
        // Under a private string, bank.balance cannot be accessed or changed outside of the class
        Console.WriteLine($"You have ${bank.GetAccountBalance()}");
        bank.withdraw();
        Console.WriteLine($"You have ${bank.GetAccountBalance()}");
    }
}