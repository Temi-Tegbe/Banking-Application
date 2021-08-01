using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Application
{
    public class BankAccount : IBankAccount
    {

        private double _accountBalance;

        private string _accountName;

        private string _accountNumber;

        private string _accountType;

        public BankAccount(string accountName, string accountNumber, string accountType, double startingBalance = 0)
        {
            _accountName = accountName;
            _accountNumber = accountNumber;
            _accountType = accountType;
            _accountBalance = startingBalance;


        }
        public string AccountName => _accountName;
        public string AccountNumber => _accountNumber;
        public string AccountType => _accountType;



        public double Deposit(double amountToDeposit)
        {
            //Validate the input value
            if (amountToDeposit<=0)
            {
                Console.WriteLine("Invalid amount! Please enter a positive value");
            }
            else
            {
                _accountBalance += amountToDeposit;
            }
            return _accountBalance;
        }

        public double Withdraw(double amountToWithdraw)
        {
            //Validate the output value
            //
            if (amountToWithdraw <= 0)
            {
                Console.WriteLine("Invalid amount! Please enter a positive value");
            }
            else if (amountToWithdraw > _accountBalance)
            {
                Console.WriteLine("Insufficient funds!");
            }
            else
            {
                _accountBalance -= amountToWithdraw;
            }

            return _accountBalance;
        }


        public double CheckBalance()
        {
            throw new NotImplementedException();
        }

       

        
    }
}
