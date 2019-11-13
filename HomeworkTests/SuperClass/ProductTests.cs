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
    public class ProductTests
    {
        // product test
        [TestMethod()]
        public void TestProduct()
        {
            Category category = new Category("CPU", 1);
            Product product = new Product("3700x", category, "12000", "3700x_8c16t", Constant.RESOURCE_PATH + "/CPU/0.jpg", "1");
            Assert.AreEqual(product.Name, "3700x");
            Assert.AreEqual(product.Category.Name, "CPU");
            Assert.AreEqual(product.Category.Count, 1);
            Assert.AreEqual(product.Price, "12000");
            Assert.AreEqual(product.Description, "3700x_8c16t");
            Assert.AreEqual(product.ImagePath, Constant.RESOURCE_PATH + "/CPU/0.jpg");
            Assert.AreEqual(product.Quantity, "1");
        }
    }
}