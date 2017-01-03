using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Household.Domain.Model.DataInterface;
using Household.Domain.Model.Entities;
using Household.Domain.Services;

using Rhino.Mocks;


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

        [TestInitialize]
        public void TestSetup()
        {
            mock = new MockRepository();
            transactionAmt = 10.5M;
            investmentFundId = 2;
            accountId = 3;
            testInvestmnt = new Investment(accountId, investmentFundId);
        }

        [TestMethod]
        public void UpdatingPrincipleCallsRepository()
        {
            var initialBalance = testInvestmnt.Balance;

            IInvestmentRepository repository = mock.StrictMock<IInvestmentRepository>();
            //repository.Stub(rep => rep.UpdateInvestmentPrinciple(Arg<Investment>.Is.Anything, Arg<decimal>.Is.Anything));
            repository.Expect(rep => rep.UpdateInvestmentPrinciple(testInvestmnt, transactionAmt)).Return(initialBalance + transactionAmt);
            var svc = new InvestmentService(repository);
            svc.UpdateInvestmentPrinciple(testInvestmnt, transactionAmt);

            //repository.AssertWasCalled(rep => rep.UpdateInvestmentPrinciple(Arg<Investment>.Is.Anything, Arg<decimal>.Is.Anything));
            //repository.AssertWasCalled(rep => rep.UpdateInvestmentPrinciple(Arg<Investment>.Is.Equal(testInvestmnt), Arg<decimal>.Is.Equal(transactionAmt)));
            repository.VerifyAllExpectations();
        }

        //[TestMethod]
        //public void UpdatingPrincipleReturnsInvestmentBalance()
        //{
            
        //    var testInvestmnt = new Investment(accountId, investmentFundId);
        //    var initialBalance = testInvestmnt.Balance;

        //    IInvestmentRepository repository = mock.StrictMock<IInvestmentRepository>();
        //    repository.Stub(rep => rep.UpdateInvestmentPrinciple(Arg<Investment>.Is.Anything, Arg<decimal>.Is.Anything));
            
        //    var svc = new InvestmentService(repository);
        //    svc.UpdateInvestmentPrinciple(testInvestmnt, transactionAmt);

        //    var expectedBalance = initialBalance + transactionAmt;

        //    Assert.AreEqual(expectedBalance, testInvestmnt.Balance);
        //}

        
    }
}
