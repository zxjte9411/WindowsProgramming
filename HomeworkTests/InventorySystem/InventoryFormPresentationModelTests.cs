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
    public class InventoryFormPresentationModelTests
    {
        Model model;
        InventoryFormPresentationModel inventoryFormPresentationModel;
        Category category;
        Product product;
        bool flagtest;

        // event test
        private void EventTest(int rowIndex)
        {
            flagtest = true;
        }
        
        // test Initialize
        [TestInitialize]
        public void TestInitialize()
        {
            model = new Model();
            inventoryFormPresentationModel = new InventoryFormPresentationModel(model);
            category = new Category("test", 1);
            product = new Product("3700xtest", category, "10000", "8c16txtest", Constant.RESOURCE_PATH + "CPU/0.jpg", "3");
            model.ProductList.Add(product);
            model.ProductCategory.Add(category);
        }

        // test InventoryFormPresentationModel
        [TestMethod()]
        public void TestInventoryFormPresentationModel()
        {
            Assert.AreEqual(inventoryFormPresentationModel.Model, model);
        }

        // test HandleDataGridViewPerformance
        [TestMethod()]
        public void TestHandleDataGridViewPerformance()
        {
            inventoryFormPresentationModel._selectCellEvent += EventTest;
            inventoryFormPresentationModel._replacementEvent += EventTest;
            inventoryFormPresentationModel.HandleDataGridViewPerformance(0, 0);
            Assert.AreEqual(flagtest, true);
            flagtest = false;
            inventoryFormPresentationModel.HandleDataGridViewPerformance(0, 4);
            Assert.AreEqual(flagtest, true);
            flagtest = false;
            inventoryFormPresentationModel.HandleDataGridViewPerformance(0, 3);
            Assert.AreEqual(flagtest, false);
        }

        // test GetRowData
        [TestMethod()]
        public void TestGetRowData()
        {
            Assert.AreEqual(inventoryFormPresentationModel.GetRowData(product)[0], product.Name);
        }
    }
}