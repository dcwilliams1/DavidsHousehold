using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Household.Domain.Model.DataInterface;
using Household.Domain.Model.Entities;
using Household.Domain.Model.ValueObjects;
using Household.Domain.Services;

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
        IInvestmentRepository repository;
        InvestmentService svc;

        [TestInitialize]
        public void TestSetup()
        {
            mock = new MockRepository();
            repository = mock.StrictMock<IInvestmentRepository>();
            testInvestmnt = new Investment(accountId, investmentFundId);
            svc = new InvestmentService(repository);
            transactionAmt = 10.5M;
            investmentFundId = 2;
            accountId = 3;
        }

        [TestMethod]
        public void UpdatingPrincipleCallsRepository()
        {
            var initialBalance = testInvestmnt.Balance;
            repository.Expect(rep => rep.UpdateInvestmentPrinciple(testInvestmnt, transactionAmt)).Return(initialBalance + transactionAmt);
            repository.Replay();

            svc.UpdateInvestmentPrinciple(testInvestmnt, transactionAmt);

            repository.AssertWasCalled(rep => rep.UpdateInvestmentPrinciple(Arg<Investment>.Is.Anything, Arg<decimal>.Is.Anything));
        }

        [TestMethod]
        public void UpdatingPrincipleReturnsInvestmentBalance()
        {
            var initialBalance = testInvestmnt.Balance;
            repository.Expect(rep => rep.UpdateInvestmentPrinciple(testInvestmnt, transactionAmt)).Return(initialBalance + transactionAmt);
            repository.Replay();

            var actualBalance = svc.UpdateInvestmentPrinciple(testInvestmnt, transactionAmt);
            var expectedBalance = initialBalance + transactionAmt;
            
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            repository.VerifyAllExpectations();
            
        }


    }
}
