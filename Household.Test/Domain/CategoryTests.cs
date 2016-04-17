using System;
using Household.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Core;

namespace Household.Test.Domain
{
    [TestClass]
    public class CategoryTests
    {
        [TestMethod]
        public void CategoryIsCreatedWithCorrectName()
        {
            var expectedName = "testName";
            var budCategory = new BudgetCategory(expectedName);
            var actualName = budCategory.Name;
            Assert.AreEqual(expectedName, actualName);
        }
    }
}
