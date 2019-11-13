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
    public class OrderFormPresentationModelTests
    {
        Model model;
        OrderFormPresentationModel orderFormPresentationModel;
        Category category;
        Product product;
        bool flagtest;
        // event test
        private void EventTest(int rowIndex, string total)
        {
            flagtest = true;
        }

        // test Initialize
        [TestInitialize]
        public void TestInitialize()
        {
            flagtest = false;
            model = new Model();
            orderFormPresentationModel = new OrderFormPresentationModel(model);
            category = new Category("test", 1);
            product = new Product("3700xtest", category, "10000", "8c16txtest", Constant.RESOURCE_PATH + "CPU/0.jpg", "3");
            model.ProductList.Add(product);
            model.ProductCategory.Add(category);
        }

        // test OrderFormPresentationModel
        [TestMethod()]
        public void TestOrderFormPresentationModel()
        { 
            Assert.AreEqual(orderFormPresentationModel.ProductCategorysName.Last(), "test");
            Assert.AreEqual(orderFormPresentationModel.CurrentUserSelectProductQuantity, "");
            orderFormPresentationModel.Model.ClearUserSelectProduct();
            orderFormPresentationModel.GetProduct("test", 0);
            Assert.AreEqual(orderFormPresentationModel.CurrentUserSelectProductQuantity, Constant.STOCK_QUANTITY + "3");
            Assert.AreEqual(orderFormPresentationModel.IsOrderButtonEnable, false);
            orderFormPresentationModel.AddProduct();
            orderFormPresentationModel.Model.ClearUserSelectProduct();
        }

        // test HandleDataGridViewPerformance
        [TestMethod()]
        public void TestHandleDataGridViewPerformance()
        {
            orderFormPresentationModel._deleteEvent += EventTest;
            orderFormPresentationModel._changeQuantityEvent += EventTest;
            orderFormPresentationModel.GetProduct("test", 0);
            orderFormPresentationModel.AddProduct();
            orderFormPresentationModel.HandleDataGridViewPerformance(0, 0, null);
            Assert.AreEqual(orderFormPresentationModel.Model.Order.UserSelectProduct.Count, 0);
            Assert.AreEqual(flagtest, true);
            orderFormPresentationModel.GetProduct("test", 0);
            orderFormPresentationModel.AddProduct();
            orderFormPresentationModel.HandleDataGridViewPerformance(0, 4, 5);
            Assert.AreEqual(model.Order.UserSelectedProductsQuantity[0], 3);
            Assert.AreEqual(flagtest, true);
            orderFormPresentationModel.HandleDataGridViewPerformance(-1, 2, null);
        }

        // test UpdatePages
        [TestMethod()]
        public void TestUpdatePages()
        {
            orderFormPresentationModel.UpdatePages(1);
            Assert.AreEqual(orderFormPresentationModel.IsHaveNextPage, false);
            Assert.AreEqual(orderFormPresentationModel.IsHavePreviousPage, false);
            orderFormPresentationModel.UpdatePages(10);
            Assert.AreEqual(orderFormPresentationModel.IsHaveNextPage, true);
            Assert.AreEqual(orderFormPresentationModel.IsHavePreviousPage, false);
        }

        // test GetCurrentPageProductsImagePath
        [TestMethod()]
        public void TestGetCurrentPageProductsImagePath()
        {
            Assert.AreEqual(orderFormPresentationModel.GetCurrentPageProductsImagePath("test")[0], Constant.RESOURCE_PATH + "CPU/0.jpg");
        }

        // test GetProduct
        [TestMethod()]
        public void TestGetProduct()
        {
            Assert.AreEqual(orderFormPresentationModel.GetProduct("test", 0), product);
            Assert.AreEqual(orderFormPresentationModel.IsButtonAddEnable, true);
        }

        // test GetRowData
        [TestMethod()]
        public void TestGetRowData()
        {
            orderFormPresentationModel.GetProduct("test", 0);
            Assert.AreEqual(orderFormPresentationModel.GetRowData()[1], "3700xtest");
            Assert.AreEqual(orderFormPresentationModel.GetRowData()[2], category.Name);
            Assert.AreEqual(orderFormPresentationModel.GetRowData()[3], "10,000");
            Assert.AreEqual(orderFormPresentationModel.GetRowData()[4], "1");
            Assert.AreEqual(orderFormPresentationModel.GetRowData()[5], "10,000");
        }

        // test AddProduct
        [TestMethod()]
        public void TestAddProduct()
        {
            orderFormPresentationModel.GetProduct("test", 0);
            orderFormPresentationModel.AddProduct();
            Assert.AreEqual(orderFormPresentationModel.Model.Order.UserSelectProduct[0], product);
            Assert.AreEqual(orderFormPresentationModel.IsOrderButtonEnable, true);
        }

        // test GetTotalPriceText
        [TestMethod()]
        public void TestGetTotalPriceText()
        {
            Assert.AreEqual(orderFormPresentationModel.GetTotalPriceText(), Constant.TOTAL + "0" + Constant.DOLLAR);
            orderFormPresentationModel.GetProduct("test", 0);
            orderFormPresentationModel.AddProduct();
            Assert.AreEqual(orderFormPresentationModel.GetTotalPriceText(), Constant.TOTAL + "10,000" + Constant.DOLLAR);
        }

        // test IsProductButtonVisible
        [TestMethod()]
        public void TestIsProductButtonVisible()
        {
            Assert.AreEqual(orderFormPresentationModel.IsProductButtonVisible(5, "test"), false);
            Assert.AreEqual(orderFormPresentationModel.IsProductButtonVisible(0, "test"), true);
            orderFormPresentationModel.Model.ProductCategory.Clear();
            Assert.AreEqual(orderFormPresentationModel.IsProductButtonVisible(0, "test"), false);
        }

        // test GoNextPage
        [TestMethod()]
        public void TestGoNextPage()
        {
            orderFormPresentationModel.CurrentPageNumber = 1;
            orderFormPresentationModel.UpdatePages(50);
            orderFormPresentationModel.GoNextPage();
            orderFormPresentationModel.GoNextPage();
            Assert.AreEqual(orderFormPresentationModel.CurrentPageNumber, 3);
            Assert.AreEqual(orderFormPresentationModel.IsHavePreviousPage, true);
            Assert.AreEqual(orderFormPresentationModel.IsHaveNextPage, true);
            orderFormPresentationModel.CurrentPageNumber = 1;
            orderFormPresentationModel.UpdatePages(5);
            Assert.AreEqual(orderFormPresentationModel.IsHavePreviousPage, false);
            Assert.AreEqual(orderFormPresentationModel.IsHaveNextPage, false);
        }

        // test GoPreviousPage
        [TestMethod()]
        public void TestGoPreviousPage()
        {
            orderFormPresentationModel.CurrentPageNumber = 3;
            orderFormPresentationModel.UpdatePages(50);
            orderFormPresentationModel.GoPreviousPage();
            Assert.AreEqual(orderFormPresentationModel.IsHavePreviousPage, true);
            Assert.AreEqual(orderFormPresentationModel.IsHaveNextPage, true);
            orderFormPresentationModel.CurrentPageNumber = 1;
            orderFormPresentationModel.UpdatePages(5);
            Assert.AreEqual(orderFormPresentationModel.IsHavePreviousPage, false);
            Assert.AreEqual(orderFormPresentationModel.IsHaveNextPage, false);
        }

        // test GetPageNumberText
        [TestMethod()]
        public void TestGetPageNumberText()
        {
            orderFormPresentationModel.UpdatePages(15);
            Assert.AreEqual(orderFormPresentationModel.GetPageNumberText(), "1" + Constant.SLASH + "3");
        }
    }
}