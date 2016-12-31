using System;
using Household.Domain.Entities;
using Household.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Household.Test.Domain
{
    [TestClass]
    public class TransactionTests
    {
        [TestMethod]
        public void TransactionIsCreatedWithInvestmentAndAmount()
        {
            var expectedTransactionAmt = 10.5M;
            var expectedInvestmentFundId = 2;
            var expectedInvestentAccountId = 3;
            var expectedInvestmnt = new Investment(expectedInvestentAccountId, expectedInvestmentFundId);

            var tx = new Transaction(expectedInvestmnt, expectedTransactionAmt);

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
            var expectedInvestmentFundId = 2;
            var expectedInvestentAccountId = 3;
            var expectedInvestmnt = new Investment(expectedInvestentAccountId, expectedInvestmentFundId);

            var tx = new Transaction(expectedInvestmnt, expectedTransactionAmt);

            var actualTransactionAmt = tx.Amount;
            var actualInvestmentFundID = tx.Investment.FundId;
            var actualInvestmentAccountID = tx.Investment.AccountId;

            Assert.AreEqual(expectedTransactionAmt, actualTransactionAmt);
            Assert.AreEqual(expectedInvestmentFundId, actualInvestmentFundID);
            Assert.AreEqual(expectedInvestentAccountId, actualInvestmentAccountID);
        }

        [TestMethod]
        public void TransactionUpdatesInvestmentBalance()
        {
            var transactionAmt = 10.5M;
            var investmentFundId = 2;
            var accountId = 3;
            var expectedInvestmnt = new Investment(accountId, investmentFundId);
            var initialBalance = expectedInvestmnt.Balance;

            var tx = new Transaction(expectedInvestmnt, transactionAmt);
            var expectedBalance = initialBalance + transactionAmt;

            Assert.AreEqual(expectedBalance, tx.Investment.Balance);
        }

    }
}
