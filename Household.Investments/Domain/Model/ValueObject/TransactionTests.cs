using System;
using Household.Investments.Domain.Model.Entity;
using Household.Investments.Domain.Model.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Household.Investments.Domain.Model.ValueObject.Test
{
    [TestClass]
    public class TransactionTests
    {
        decimal transactionAmt;
        int investmentFundId;
        int accountId;
        Investment testInvestmnt;


        [TestInitialize]
        public void TestSetup()
        {
            transactionAmt = 10.5M;
            investmentFundId = 2;
            accountId = 3;
            testInvestmnt = new Investment(accountId, investmentFundId);
        }

        [TestMethod]
        public void TransactionIsCreatedWithInvestmentAndAmount()
        {
            var expectedTransactionAmt = transactionAmt;
            var expectedInvestmentFundId = investmentFundId;
            var expectedInvestentAccountId = accountId;
            var expectedInvestmnt = new Investment(expectedInvestentAccountId, expectedInvestmentFundId);

            var tx = new InvestmentTransaction(expectedInvestmnt, expectedTransactionAmt);

            var actualTransactionAmt = tx.Amount;
            var actualInvestmentFundID = tx.Investment.FundId;
            var actualInvestmentAccountID = tx.Investment.AccountId;

            Assert.AreEqual(expectedTransactionAmt, actualTransactionAmt);
            Assert.AreEqual(expectedInvestmentFundId, actualInvestmentFundID);
            Assert.AreEqual(expectedInvestentAccountId, actualInvestmentAccountID);
        }

        [TestMethod]
        public void TransactionAmountCanBeNegative()
        {
            var expectedTransactionAmt = -10.5M;
            var expectedInvestmentFundId = investmentFundId;
            var expectedInvestentAccountId = accountId;
            var expectedInvestmnt = new Investment(expectedInvestentAccountId, expectedInvestmentFundId);

            var tx = new InvestmentTransaction(expectedInvestmnt, expectedTransactionAmt);

            var actualTransactionAmt = tx.Amount;
            var actualInvestmentFundID = tx.Investment.FundId;
            var actualInvestmentAccountID = tx.Investment.AccountId;

            Assert.AreEqual(expectedTransactionAmt, actualTransactionAmt);
            Assert.AreEqual(expectedInvestmentFundId, actualInvestmentFundID);
            Assert.AreEqual(expectedInvestentAccountId, actualInvestmentAccountID);
        }

        [TestMethod]
        public void TransactionUpdatesInvestmentPrinciple()
        {
            var invstmt = new Investment(accountId, investmentFundId);
            var initialPrinciple = invstmt.Principle;

            var tx = new InvestmentTransaction(invstmt, transactionAmt);

            Assert.AreEqual(invstmt.Principle, initialPrinciple + tx.Amount);

        }
    }
}
