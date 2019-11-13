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
    public class OrderTests
    {
        Order order;
        Product product;
        CreditCardPayment creditCardPayment;

        // test initialize
        [TestInitialize]
        public void TestInitialize()
        {
            order = new Order();
            product = new Product("testName", new Category("CPU", 1), "1000", "test", Constant.RESOURCE_PATH + "/CPU/0.jpg", "1");
            creditCardPayment = new CreditCardPayment();
            order.CreditCardPayment = creditCardPayment;
            order.AddSelectProductToList(product);
            order.UserSelectedProductsQuantity.Add(1);
        }

        // test order
        [TestMethod()]
        public void TestOrder()
        {
            Assert.AreEqual(order.UserSelectedProductsQuantity[0], 1);
            Assert.AreEqual(order.UserSelectProduct[0], product);
            Assert.AreEqual(order.CreditCardPayment, creditCardPayment);
        }

        // test AddSelectProductToList
        [TestMethod()]
        public void TestAddSelectProductToList()
        {
            Product product2 = new Product("testName2", new Category("CPU2", 1), "10002", "test2", Constant.RESOURCE_PATH + "/CPU/1.jpg", "1");
            order.AddSelectProductToList(product2);
            Assert.AreEqual(order.UserSelectProduct.Last(), product2);
        }

        // test GetTotalPrice
        [TestMethod()]
        public void TestGetTotalPrice()
        {
            Assert.AreEqual(order.GetTotalPrice(), 1000);
        }

        // test DeleteProduct
        [TestMethod()]
        public void TestDeleteProduct()
        {
            order.DeleteProduct(0);
            Assert.AreEqual(order.UserSelectProduct.Count, 0);
        }

        // test GetUserSelectProductInList
        [TestMethod()]
        public void TestGetUserSelectProductInList()
        {
            string[] userSelectedProductInStringArray = new string[6];
            userSelectedProductInStringArray[0] = string.Empty;
            userSelectedProductInStringArray[1] = order.UserSelectProduct[0].Name;
            userSelectedProductInStringArray[2] = order.UserSelectProduct[0].Category.Name;
            userSelectedProductInStringArray[3] = "1,000";
            userSelectedProductInStringArray[4] = "1";
            userSelectedProductInStringArray[5] = "1,000";
            for (int i = 0; i < 6; i++)
                Assert.AreEqual(order.GetUserSelectProductInList()[0][i], userSelectedProductInStringArray[i]);
        }

        // test GetCustomerSelectedProductSubtotal
        [TestMethod()]
        public void TestGetCustomerSelectedProductSubtotal()
        {
            Assert.AreEqual(order.GetCustomerSelectedProductSubtotal(0), 1000);
        }

        // test CalculateRemainingStockQuantity
        [TestMethod()]
        public void TestCalculateRemainingStockQuantity()
        {
            order.CalculateRemainingStockQuantity();
            Assert.AreEqual(order.UserSelectProduct[0].Quantity, "0");
        }

        // test IsHaveThisProduct
        [TestMethod()]
        public void TestIsHaveThisProduct()
        {
            Assert.AreEqual(order.IsHaveThisProduct("testName2"), false);
            Assert.AreEqual(order.IsHaveThisProduct("testName"), true);
        }
    }
}