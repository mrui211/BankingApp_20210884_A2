using BankingApp_20210884;
namespace BankingAppTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void EverydayAccount_Deposit()
        {
            var account = new EverydayAccount(100);
            account.Deposit(50);
            Assert.AreEqual(150, account.Balance);
        }

        [TestMethod]
        public void EverydayAccount_Withdraw()
        {
            var account = new EverydayAccount(100);
            bool result = account.Withdraw(50);
            Assert.IsTrue(result);
            Assert.AreEqual(50, account.Balance);
        }

        [TestMethod]
        public void EverydayAccount_WithdrawInsufficientFunds()
        {
            var account = new EverydayAccount(100);
            bool result = account.Withdraw(150);
            Assert.IsFalse(result);
            Assert.AreEqual(100, account.Balance);
        }

        [TestMethod]
        public void InvestmentAccount_CalculateInterest()
        {
            var account = new InvestmentAccount(1000);
            double interest = account.CalculateInterest();
            Assert.AreEqual(40, interest); 
        }

        [TestMethod]
        public void OmniAccount_Withdraw_WithinOverdraftLimit()
        {
            var account = new OmniAccount(100);
            bool result = account.Withdraw(800);
            Assert.IsTrue(result);
            Assert.AreEqual(-700, account.Balance);
        }

        [TestMethod]
        public void OmniAccount_Withdraw_ExceedingOverdraftLimit()
        {
            var account = new OmniAccount(100);
            bool result = account.Withdraw(900);
            Assert.IsFalse(result);
            Assert.AreEqual(100, account.Balance);
        }

        [TestMethod]
        public void OmniAccount_CalculateInterest()
        {
            var account = new OmniAccount(1000);
            double interest = account.CalculateInterest();
            Assert.AreEqual(70, interest); 
        }
    }
}