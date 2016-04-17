using System;
using Household.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Household.Test.Domain
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
    }
}
