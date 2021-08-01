using Banking_Application;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApplication.Tests
{
    [TestClass]
    public class BankApplicationTests
    {

        //Testing method Deposit()
        //Test for negative amount
        //Test for valid amount
        //Test for non-numeric input

        [TestMethod]
        public void Deposit_NegativeAmount_BalanceUnchanged()
        {
            //Arrange
            BankAccount account = new BankAccount("Demo Account", "0001023459", "Current");
            double initiaBalance = 0;
            double amountToDeposit = -5000;
            double expectedResult = 0;



            //Act

            double actualResult = account.Deposit(amountToDeposit);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Deposit_ValidAmount_BalanceIncreased()
        {

            //Arrange 
            double initialBalance = 5000;
            BankAccount account = new BankAccount("DemoAccount2", "09989786722", "Savings", initialBalance);

            double amountToDeposit = 5000;
            double expectedResult = 10000;

            //Act

            double actualResult = account.Deposit(amountToDeposit);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void Withdraw_NegativeAmount_BalanceUnchanged()
        {
            //Arrange
            double initialBalance = 10000;
            BankAccount account = new BankAccount("DemoAccount3", "0012345678", "Savings", initialBalance);
            double amountToWithdraw = -5000;
            double expectedResult = 10000;

            //Act

            double actualResult = account.Withdraw(amountToWithdraw);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Withdraw_InsufficicentFunds_BalanceUnchanged()
        {
            //Arrange

            double initialBalance = 10000;
            BankAccount account = new BankAccount("DemoAccount4", "0123456781", "Current", initialBalance);
            double amountToWithdraw = 15000;
            double expectedResult = 10000;

            //Act

            double actualResult = account.Withdraw(amountToWithdraw);

            //Assert 

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Withdraw_SufficientBalance_BalanceChanged()
        {
            //Arrange

            double initialBalance = 10000;
            BankAccount account = new BankAccount("DemoAccount5", "0123456783", "Current", initialBalance);
            double amountToWithdraw = 10000;
            double expectedResult = 0;

            //Act
            double actualResult = account.Withdraw(amountToWithdraw);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }





    }
}

