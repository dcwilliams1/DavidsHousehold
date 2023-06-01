using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Household.Application.Service;
using Household.Supplements.Domain.Model.Entity;
using Household.SharedKernel.Data.Repository;

namespace Household.Application.Service.Test
{
    [TestClass]
    public class SupplementServiceTests
    {
        [TestMethod]
        public void AddSupplementService_CallsSupplementRepository()
        {
            var supplementInMemoryDatabase = new List<SupplementPurchase>();
            var repository = new Mock<Repository<SupplementPurchase>>();
            repository.Setup(x => x.Add(It.IsAny<SupplementPurchase>()))
                .Callback((SupplementPurchase sp) => supplementInMemoryDatabase.Add(sp));
            var testSubject = new SupplementService(repository.Object);
            var expectedSupplementPurchase = new SupplementPurchase()
            {
                Company = "Test Company",
            };

            testSubject.AddSupplementPurchase(expectedSupplementPurchase);

            Assert.IsTrue(supplementInMemoryDatabase.Count == 1);
            Assert.IsTrue(supplementInMemoryDatabase[0].Company.Equals(expectedSupplementPurchase.Company));
        }

        [TestMethod]
        public void AddSupplementService_AddsSupplementPurchaseWithCorrectPropertyValues()
        {
            var supplementInMemoryDatabase = new List<SupplementPurchase>();
            var repository = new Mock<Repository<SupplementPurchase>>();
            repository.Setup(x => x.Add(It.IsAny<SupplementPurchase>()))
                .Callback((SupplementPurchase sp) => supplementInMemoryDatabase.Add(sp));
            var testSubject = new SupplementService(repository.Object);
            var expectedSupplementPurchase = new SupplementPurchase()
            {
                Company = "Test Company",
                Price = 10.01M,
                Quantity = 2,
                Product = "Test Product",
                Count = 2
            };

            testSubject.AddSupplementPurchase(expectedSupplementPurchase);

            Assert.IsTrue(supplementInMemoryDatabase.Count == 1);
            Assert.IsTrue(supplementInMemoryDatabase[0].Company.Equals(expectedSupplementPurchase.Company));
            Assert.IsTrue(supplementInMemoryDatabase[0].Price.Equals(expectedSupplementPurchase.Price));
            Assert.IsTrue(supplementInMemoryDatabase[0].Quantity.Equals(expectedSupplementPurchase.Quantity));
            Assert.IsTrue(supplementInMemoryDatabase[0].Product.Equals(expectedSupplementPurchase.Product));
            Assert.IsTrue(supplementInMemoryDatabase[0].Count.Equals(expectedSupplementPurchase.Count));
        }
    }
}
