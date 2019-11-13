using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Tests
{
    [TestClass()]
    public class CategoryTests
    {
        Category category;

        // test initialize
        [TestInitialize]
        public void TestInitialize()
        {
            category = new Category("CPU", 1);
        }

        // category test
        [TestMethod()]
        public void TestCategory()
        {
            Assert.AreEqual(category.Name, "CPU");
            Assert.AreEqual(category.Count, 1);
        }

        // Compare Count test
        [TestMethod()]
        public void TestCompareCount()
        {
            Assert.AreEqual(category.CompareCount(category), category);
            Category category2 = new Category("REM", 1);
            Assert.AreEqual(category2.CompareCount(category), category);
        }
    }
}