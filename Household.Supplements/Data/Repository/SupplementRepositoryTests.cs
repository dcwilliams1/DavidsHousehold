using Microsoft.VisualStudio.TestTools.UnitTesting;
using Household.Data.EntityFramework;
using Household.Supplements.Data.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household.Data.EntityFramework.Test
{
    [TestClass]
    public class SupplementRepositoryTests
    {
        [TestMethod]
        public void Add_Supplement_AddsRecordToDatabase()
        {
            //var supplementInMemoryDatabase = new List<SupplementPurchase>();
            //var repository = new Mock<IRepository<SupplementPurchase>>();
            //repository.Setup(x => x.Add(It.IsAny<SupplementPurchase>())
            //    .Callback((SupplementPurchase sp) => supplementInMemoryDatabase.Add(sp)));
        }
    }
}

//https://stackoverflow.com/questions/17902579/repository-pattern-and-unit-testing-from-memory  