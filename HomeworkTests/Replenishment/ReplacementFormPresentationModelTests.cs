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
    public class ReplacementFormPresentationModelTests
    {
        ReplacementFormPresentationModel replacementFormPresentationModel;
        Model model;
        Category category;
        Product product;
        bool flagTest;

        // test event
        private void EventTest()
        {
            flagTest = true;
        }

        // test Initialize
        [TestInitialize]
        public void TestInitialize()
        {
            model = new Model();
            replacementFormPresentationModel = new ReplacementFormPresentationModel(model);
            category = new Category("test", 1);
            product = new Product("3700xtest", category, "10000", "8c16txtest", Constant.RESOURCE_PATH + "CPU/0.jpg", "3");
            flagTest = false;
            model.ProductList.Add(product);
        }
        // test ReplacementFormPresentationModel
        [TestMethod()]
        public void TestReplacementFormPresentationModel()
        {
            Assert.AreEqual(replacementFormPresentationModel.Model, model);
        }

        // test HandleStockQuantityChange
        [TestMethod()]
        public void TestHandleStockQuantityChange()
        {
            replacementFormPresentationModel.Model._stockQuantityProductChangeEvent += EventTest;
            replacementFormPresentationModel.HandleStockQuantityChange(model.ProductList.Count - 1, "5");
            Assert.AreEqual(model.ProductList.Last().Quantity, "8");
            Assert.AreEqual(flagTest, true);
        }
    }
}