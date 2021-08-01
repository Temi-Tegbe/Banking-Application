using System;

namespace Banking_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount janesAccount = new BankAccount("Jane Okeke", "0130939002", "Current");

            BankAccount BoyosAccount = new BankAccount("Boyo Odometa", "0130939003", "Current", 0);

            BankAccount TemisAccount = new BankAccount("Temi Tegbe", "0130939056", "Savings", 100000);
        }
    }
}
