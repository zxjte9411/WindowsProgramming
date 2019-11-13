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
    public class ProductManagementPresentationModelTests
    {
        ProductManagementPresentationModel productManagementPresentationModel;
        Model model;
        Category category;
        Product product;
        bool flagTest;

        // test Initialize
        [TestInitialize]
        public void TestInitialize()
        {
            model = new Model();
            productManagementPresentationModel = new ProductManagementPresentationModel(model);
            category = new Category("test", 1);
            product = new Product("3700xtest", category, "10000", "8c16txtest", Constant.RESOURCE_PATH + "CPU/0.jpg", "3");
            flagTest = false;
            model.ProductList.Add(product);
            model.ProductCategory.Add(category);
            productManagementPresentationModel.PropertyChanged += EventTest;
        }

        // test event
        private void EventTest(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            flagTest = true;
        }

        // test eveent
        private void EventTest(string stringText)
        {
            flagTest = true;
        }

        // test event
        private void EventTest()
        {
            flagTest = true;
        }

        // test ProductManagementPresentationModel
        [TestMethod()]
        public void TestProductManagementPresentationModel()
        {
            Assert.AreEqual(productManagementPresentationModel.Model, model);
            Assert.AreEqual(productManagementPresentationModel.Mode, Constant.Mode.InitialMode);
        }

        // test UpdateModeChangedState
        [TestMethod()]
        public void TestUpdateModeChangedState()
        {
            productManagementPresentationModel.Mode = Constant.Mode.InitialMode;
            productManagementPresentationModel.UpdateModeChangedState();
            Assert.AreEqual(productManagementPresentationModel.ButtonSaveAddText, "儲存");
            Assert.AreEqual(productManagementPresentationModel.GroupBoxProductText, "編輯商品");
            Assert.AreEqual(productManagementPresentationModel.IsButtonSaveAddEnable, false);
            Assert.AreEqual(productManagementPresentationModel.IsButtonAddEnable, true);
            productManagementPresentationModel.Mode = Constant.Mode.AddMode;
            productManagementPresentationModel.UpdateModeChangedState();
            Assert.AreEqual(productManagementPresentationModel.ButtonSaveAddText, "新增");
            Assert.AreEqual(productManagementPresentationModel.GroupBoxProductText, "新增商品");
            Assert.AreEqual(productManagementPresentationModel.IsButtonSaveAddEnable, false);
            Assert.AreEqual(productManagementPresentationModel.IsButtonAddEnable, false);
            productManagementPresentationModel.Mode = Constant.Mode.EditMode;
            productManagementPresentationModel.UpdateModeChangedState();
            Assert.AreEqual(productManagementPresentationModel.ButtonSaveAddText, "儲存");
            Assert.AreEqual(productManagementPresentationModel.GroupBoxProductText, "編輯商品");
            Assert.AreEqual(productManagementPresentationModel.IsButtonSaveAddEnable, false);
            Assert.AreEqual(productManagementPresentationModel.IsButtonAddEnable, true);
        }

        // test HandleNewProductAddButtonClickEvent
        [TestMethod()]
        public void TestHandleNewProductAddButtonClickEvent()
        {
            productManagementPresentationModel.HandleNewProductAddButtonClickEvent();
            Assert.AreEqual(productManagementPresentationModel.ButtonSaveAddText, "新增");
            Assert.AreEqual(productManagementPresentationModel.GroupBoxProductText, "新增商品");
            Assert.AreEqual(productManagementPresentationModel.IsButtonSaveAddEnable, false);
            Assert.AreEqual(productManagementPresentationModel.IsButtonAddEnable, false);
        }

        //test HandleProductListBoxSelected
        [TestMethod()]
        public void TestHandleProductListBoxSelected()
        {
            productManagementPresentationModel.HandleProductListBoxSelected();
            Assert.AreEqual(productManagementPresentationModel.ButtonSaveAddText, "儲存");
            Assert.AreEqual(productManagementPresentationModel.GroupBoxProductText, "編輯商品");
            Assert.AreEqual(productManagementPresentationModel.IsButtonSaveAddEnable, false);
            Assert.AreEqual(productManagementPresentationModel.IsButtonAddEnable, true);
        }

        // ttest CheckButtonIsCanEnable
        [TestMethod()]
        public void TestCheckButtonIsCanEnable()
        {
            string[] stringText = new string[5] { "", "", "", "", "" };
            productManagementPresentationModel.CheckButtonIsCanEnable(stringText);
            Assert.AreEqual(productManagementPresentationModel.IsButtonSaveAddEnable, false);
            for (int i = 0; i < stringText.Length; i++)
            {
                stringText[i] = "test";
            }
            productManagementPresentationModel.CheckButtonIsCanEnable(stringText);
            Assert.AreEqual(productManagementPresentationModel.IsButtonSaveAddEnable, true);
        }

        // test HandleTextBoxKeyPress
        [TestMethod()]
        public void TestHandleTextBoxKeyPress()
        {
            Assert.AreEqual(productManagementPresentationModel.HandleTextBoxKeyPress((char)49, (char)8), true);
            Assert.AreEqual(productManagementPresentationModel.HandleTextBoxKeyPress((char)65, (char)8), false);
        }

        // test HandleButtonClickEvent
        [TestMethod()]
        public void TestHandleButtonClickEvent()
        {
            model._backEndChangeEvent += EventTest;
            productManagementPresentationModel._clearAllDataEvent += EventTest;
            string[] stringText = new string[5];
            stringText[0] = product.Name;
            stringText[1] = "0";
            stringText[2] = product.Category.Name;
            stringText[3] = product.ImagePath;
            stringText[4] = "111111111111111111111111111111111111";
            productManagementPresentationModel.Mode = Constant.Mode.EditMode;
            productManagementPresentationModel.HandleButtonClickEvent(model.ProductList.Count - 1, stringText);
            Assert.AreEqual(model.ProductList.Last().Price, "0");
            Assert.AreEqual(model.ProductList.Last().Description, "111111111111111111111111111111111111");
            Assert.AreEqual(flagTest, true);
            flagTest = false;
            productManagementPresentationModel.Mode = Constant.Mode.AddMode;
            stringText[0] = "test22";
            stringText[1] = "50";
            stringText[4] = "test22";
            productManagementPresentationModel.HandleButtonClickEvent(0, stringText);
            Assert.AreEqual(model.ProductList.Last().Name, "test22");
            Assert.AreEqual(model.ProductList.Last().Price, "50");
            Assert.AreEqual(model.ProductList.Last().Description, "test22");
            Assert.AreEqual(flagTest, true);
        }

        // test HandleButtonNewClickEvent
        [TestMethod()]
        public void TestHandleButtonNewClickEvent()
        {
            model._backEndNewCategoryEvent += EventTest;
            productManagementPresentationModel._clearAllDataEvent += EventTest;
            productManagementPresentationModel.Mode = Constant.Mode.AddMode;
            productManagementPresentationModel.HandleButtonNewClickEvent("測試機殼");
            Assert.AreEqual(model.ProductCategory.Last().Name, "測試機殼");
            Assert.AreEqual(flagTest, true);
        }

        // test InitializeAllStatus
        [TestMethod()]
        public void TestInitializeAllStatus()
        {
            productManagementPresentationModel.InitializeAllStatus();
            Assert.AreEqual(productManagementPresentationModel.Mode, Constant.Mode.InitialMode);
        }

        // test GroupBoxCategoryText
        [TestMethod()]
        public void TestGroupBoxCategoryText()
        {
            Assert.AreEqual(productManagementPresentationModel.GroupBoxCategoryText, "類別");
            productManagementPresentationModel.Mode = Constant.Mode.AddMode;
            productManagementPresentationModel.UpdateModeChangedState();
            Assert.AreEqual(productManagementPresentationModel.GroupBoxCategoryText, "新增類別");
        }
    }
}