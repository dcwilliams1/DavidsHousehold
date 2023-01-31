using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Household.Domain.Model.DataInterface;
using Household.Domain.Model.Entities;
using Household.Domain.Model.ValueObjects;
using Household.Domain.Services;
using System.Data;

using Rhino.Mocks;
//see http://www.wrightfully.com/using-rhino-mocks-quick-guide-to-generating-mocks-and-stubs/


namespace Household.Domain.Services.Test
{
    [TestClass]
    public class InvestmentServiceTests
    {
        MockRepository mock;
        decimal transactionAmt;
        int investmentFundId;
        int accountId;
        Investment testInvestmnt;
        IInvestmentData repository;
        InvestmentService svc;

        [TestInitialize]
        public void TestSetup()
        {
            mock = new MockRepository();
            repository = mock.StrictMock<IInvestmentData>();
            testInvestmnt = new Investment(accountId, investmentFundId);
            svc = new InvestmentService(repository);
            transactionAmt = 10.5M;
            investmentFundId = 2;
            accountId = 3;
        }

        [TestMethod]
        public void InvestmentServiceUpdatingPrincipleCallsRepository()
        {
            var initialBalance = testInvestmnt.Balance;
            repository.Expect(rep => rep.UpdateInvestmentPrinciple(testInvestmnt, transactionAmt)).Return(true);
            repository.Replay();

            svc.UpdateInvestmentPrinciple(testInvestmnt, transactionAmt);

            repository.AssertWasCalled(rep => rep.UpdateInvestmentPrinciple(Arg<Investment>.Is.Anything, Arg<decimal>.Is.Anything));
        }

        [TestMethod]
        public void InvestmentServiceUpdatingPrincipleReturnsPrinciple()
        {
            var initialBalance = testInvestmnt.Balance;
            repository.Expect(rep => rep.UpdateInvestmentPrinciple(testInvestmnt,transactionAmt)).Return(true);
            repository.Replay();

            var actualResult = svc.UpdateInvestmentPrinciple(testInvestmnt, transactionAmt);
            var expectedResult = initialBalance + transactionAmt;
            
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void InvestmentServiceThrowsExceptionWhenUpdateFails()
        {
            repository.Expect(rep => rep.UpdateInvestmentPrinciple(testInvestmnt, transactionAmt)).Throw(new DataException());
            repository.Replay();

            try
            {
                var actualResult = svc.UpdateInvestmentPrinciple(testInvestmnt, transactionAmt);
                Assert.Fail("no exception thrown");
            }
            catch(Exception ex)
            {
                Assert.IsTrue(ex is Exception);
            }

        }

        [TestCleanup]
        public void TestCleanup()
        {
            repository.VerifyAllExpectations();
            
        }


    }
}
