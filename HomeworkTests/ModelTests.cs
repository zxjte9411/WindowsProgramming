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
    public class ModelTests
    {
        Model model;
        Category category;
        Product product;
        bool flagTest;

        // event test
        void EventTest()
        {
            flagTest = true;
        }

        // test Initialize
        [TestInitialize]
        public void TestInitialize()
        {
            model = new Model();
            category = new Category("test", 0);
            product = new Product("3700x", category, "12000", "3700x_8c16t", Constant.RESOURCE_PATH + "/CPU/0.jpg", "2");
            model.GetProduct("CPU", 0);
            model.ProductList.Add(product);
            model.ProductCategory.Add(category);
            flagTest = false;
        }

        // test model
        [TestMethod()]
        public void TestModel()
        {
            Assert.AreEqual(model.CurrentUserSelectProduct.Name, "AMD Ryzen 7-3800X");
            Assert.AreEqual(model.ProductCategorysName.Last(), "test");
        }

        // test AddProductCategoryAndQuantity
        [TestMethod()]
        public void TestAddProductCategoryAndQuantity()
        {
            Category categoryTemp = model.AddProductCategoryAndQuantity("test");
            Assert.AreEqual(categoryTemp.Name, "test");
            Assert.AreEqual(categoryTemp.Count, 1);
            categoryTemp = model.AddProductCategoryAndQuantity("test2");
            Assert.AreEqual(categoryTemp.Name, "test2");
            Assert.AreEqual(categoryTemp.Count, 0);
        }

        // test GetProductsOfThisCategory
        [TestMethod()]
        public void TestGetProductsOfThisCategory()
        {
            Category categoryTemp = model.AddProductCategoryAndQuantity(category.Name);
            Assert.AreEqual(model.GetProductsOfThisCategory("test")[0], product);
        }

        // Test GetProduct
        [TestMethod()]
        public void TestGetProduct()
        {
            Assert.AreEqual(model.GetProduct("test", 0), product);
        }

        // test GetRowData
        [TestMethod()]
        public void TestGetRowData()
        {
            model.GetProduct("test", 0);
            string[] rowData = new string[6];
            rowData[0] = string.Empty;
            rowData[1] = "3700x";
            rowData[2] = "test";
            rowData[3] = "12,000";
            rowData[4] = "1";
            rowData[5] = "12,000";
            for (int i = 0; i < 6; i++)
            {
                Assert.AreEqual(model.GetRowData()[i], rowData[i]);
            }
        }

        // test AddProduct
        [TestMethod()]
        public void TestAddProduct()
        {
            model.GetProduct("test", 0);
            model.AddProduct();
            Assert.AreEqual(model.Order.UserSelectProduct[0].Name, "3700x");
        }

        // test GetProductCategoryCount
        [TestMethod()]
        public void TestGetProductCategoryCount()
        {
            Assert.AreEqual(model.GetProductCategoryCount("test"), 0);
            Assert.AreEqual(model.GetProductCategoryCount("test2"), 0);
        }

        // test UpdateOrderQuantitySubtotal
        [TestMethod()]
        public void TestUpdateOrderQuantitySubtotal()
        {
            model.GetProduct("test", 0);
            model.AddProduct();
            model.UpdateOrderQuantitySubtotal(0, 1);
            Assert.AreEqual(model.Order.UserSelectedProductsQuantity[0], 1);
        }

        // test FindTheProduct
        [TestMethod()]
        public void TestFindTheProduct()
        {
            Assert.AreEqual(model.FindTheProduct("3700x"), product);
            Assert.AreEqual(model.FindTheProduct("3700xunknow"), null);
        }

        // test CheckStockQuantityLimit
        [TestMethod()]
        public void TestCheckStockQuantityLimit()
        {
            model.GetProduct("test", 0);
            model.AddProduct();
            int quanitiy = 1;
            model.CheckStockQuantityLimit(0, ref quanitiy);
            Assert.AreEqual(quanitiy, 1);
            Assert.AreEqual(flagTest, false);
            quanitiy = 3;
            model._overStockLimitEvent += EventTest;
            model.CheckStockQuantityLimit(0, ref quanitiy);
            Assert.AreEqual(quanitiy, 2);
            Assert.AreEqual(flagTest, true);

        }

        // test ClearUserSelectProduct
        [TestMethod()]
        public void TestClearUserSelectProduct()
        {
            model.GetProduct("test", 0);
            model.AddProduct();
            int quanitiy = 1;
            model.CheckStockQuantityLimit(0, ref quanitiy);
            model._stockQuantityProductChangeEvent += EventTest;
            model.ClearUserSelectProduct();
            Assert.AreEqual(model.Order.UserSelectProduct.Count, 0);
            Assert.AreEqual(flagTest, true);
        }

        // test IncreaseStockProductQuantity
        [TestMethod()]
        public void TestIncreaseStockProductQuantity()
        {
            model._stockQuantityProductChangeEvent += EventTest;
            model.IncreaseStockProductQuantity(model.ProductList.Count - 1, "10");
            Assert.AreEqual(product.Quantity, "12");
            Assert.AreEqual(flagTest, true);
        }

        // test IsStockProductQuantityEnough
        [TestMethod()]
        public void TestIsStockProductQuantityEnough()
        {
            Assert.AreEqual(model.IsStockProductQuantityEnough("3700x"), true);
        }

        // test AddNewProductToProductList
        [TestMethod()]
        public void TestAddNewProductToProductList()
        {
            model._backEndChangeEvent += EventTest;
            string[] rowData = new string[6];
            rowData[0] = "3900x";
            rowData[1] = "12000";
            rowData[2] = "test";
            rowData[3] = "3900x_10c20t";
            rowData[4] = Constant.RESOURCE_PATH + "/CPU/0.jpg";
            rowData[5] = "5";
            model.AddNewProductToProductList(rowData);
            Assert.AreEqual(model.ProductList.Last().Name, "3900x");
            Assert.AreEqual(flagTest, true);
        }

        // test SaveChangedProductInformation
        [TestMethod()]
        public void TestSaveChangedProductInformation()
        {
            model._backEndChangeEvent += EventTest;
            model.GetProduct("test", 0);
            model.AddProduct();
            string[] rowData = new string[5];
            rowData[0] = "3900x";
            rowData[1] = "12000";
            rowData[2] = "test";
            rowData[3] = Constant.RESOURCE_PATH + "/CPU/0.jpg";
            rowData[4] = "3900x_10c20t";
            model.SaveChangedProductInformation(0, rowData);
            Assert.AreEqual(model.ProductList[0].Name, "3900x");
            Assert.AreEqual(flagTest, true);
        }
    }
}