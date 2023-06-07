using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Household.SharedKernel.Data.Repository;
using Household.Supplements.Domain.Model.Entity;
using Moq;


namespace Household.Data.EntityFramework.Test
{
    [TestClass]
    public class SupplementRepositoryTests
    {
        [TestMethod]
        public void Add_Supplement_AddsRecordToDatabase()
        {
            var supplementInMemoryDatabase = new List<SupplementPurchase>();
            var repository = new Mock<IRepository<SupplementPurchase>>();
            repository.Setup(x => x.Add(It.IsAny<SupplementPurchase>()))
                .Callback((SupplementPurchase sp) => supplementInMemoryDatabase.Add(sp));

            var expectedSupplementPurchase = new SupplementPurchase()
            {
                Company = new Company()
                {
                    Name = "Test Company"
                },
            };

            repository.Object.Add(expectedSupplementPurchase);

            Assert.IsTrue(supplementInMemoryDatabase.Count == 1);
            Assert.IsTrue(supplementInMemoryDatabase[0].Company.Equals(expectedSupplementPurchase.Company.Name));
        }
    }
}

//https://stackoverflow.com/questions/17902579/repository-pattern-and-unit-testing-from-memory  