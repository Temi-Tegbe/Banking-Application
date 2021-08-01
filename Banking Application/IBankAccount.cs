using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Application
{
    interface IBankAccount
    {
        public string AccountName { get; }
        public string AccountNumber { get; }
        public string AccountType { get; }
        public double CheckBalance();

        public double Withdraw(double amountToWithdraw);
        public double Deposit(double amountToDeposit);
    }
}
