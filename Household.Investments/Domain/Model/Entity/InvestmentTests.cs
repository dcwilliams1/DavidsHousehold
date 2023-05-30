﻿using System;
using System.Collections.Generic;
using Household.Investments.Domain.Model.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Household.Investments.Domain.Model.Entity.Test
{

    [TestClass]
    public class InvestmentTests
    {
        [TestMethod]
        public void InvestmentIsCreatedWithAccountAndFund()
        {
            int expectedAccountId = 1;
            int expectedFundId = 1;

            var investmnt = new Investment(1, 1);

            var actualAccountId = investmnt.AccountId;
            var actualFundId = investmnt.FundId;

            Assert.AreEqual(expectedAccountId, actualAccountId);
            Assert.AreEqual(expectedFundId, actualFundId);
        }

        [TestMethod]
        public void InvestmentHasBalance()
        {
            var investmnt = new Investment(1, 1);

            Assert.IsNotNull(investmnt.Balance);
            Assert.IsInstanceOfType(investmnt.Balance, typeof(decimal));
        }

        //[TestMethod]
        //public void InvestmentHasTransactions()
        //{
        //    var investmnt = new Investment(1, 1);

        //    Assert.IsNotNull(investmnt.Transactions);
        //    Assert.IsInstanceOfType(investmnt.Transactions, typeof(List<Transaction>));
        //}

        //[TestMethod]
        //public void InvestmentBalanceCanBeAddedTo()
        //{
        //    var investmnt = new Investment(1, 1);
        //    investmnt.Add(10.5M);
        //}
    }
}
