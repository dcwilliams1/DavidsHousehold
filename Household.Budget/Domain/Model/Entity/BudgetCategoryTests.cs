using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Household.Budget.Domain.Model.Entity;

namespace Household.Budget.Domain.Model.Entity.Test
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
