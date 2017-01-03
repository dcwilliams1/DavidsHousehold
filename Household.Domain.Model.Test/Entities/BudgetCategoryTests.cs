using System;
using Household.Domain.Model.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Core;

namespace Household.Domain.Model.Test
{
    [TestClass]
    public class BudgetCategoryTests
    {
        [TestMethod]
        public void BudgetCategoryIsCreatedWithCorrectName()
        {
            var expectedName = "testName";
            var budCategory = new BudgetCategory(expectedName);
            var actualName = budCategory.Name;
            Assert.AreEqual(expectedName, actualName);
        }

        [TestMethod]
        public void BudgetCategoryNameCanBeChanged()
        {
            var initialName = "Initial Name";
            var newName = "New Name";
            var budCategory = new BudgetCategory(initialName);
            Assert.AreEqual(initialName, budCategory.Name);

            budCategory.EditCategoryName(newName);
            Assert.AreEqual(newName, budCategory.Name);

        }
    }
}
