using NUnit.Framework;
using BankAccountNS;

namespace Tests
{
    public class BankAccountTest
    {
        BankAccount account;
        double initialAmount = 20.0;

        [SetUp]
        public void Setup()
        {
            account = new BankAccount("Mr Os", initialAmount);
        }

        [Test]
        public void Test1()
        {
            account.Debit(10.0);

            double balance = account.Balance;

            Assert.That(balance, Is.EqualTo(10.0).Within(0.001));
        }
    }
}