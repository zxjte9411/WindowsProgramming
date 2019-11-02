using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class ProductManagementForm : Form
    {
        private ProductManagementPresentationModel _productManagementPresentationModel;
        private int _listBoxSelectedIndex;
        private const string IS_BUTTON_PRODUCT_SAVE_ENABLE = "IsButtonSaveAddEnable";
        private const string IS_BUTTON_ADD_ENABLE = "IsButtonAddEnable";
        private const string BUTTON_SAVE_ADD_TEXT = "ButtonSaveAddText";
        private const string GROUP_BOX_MEAL_TEXT = "GroupBoxProductText";
        public ProductManagementForm(ProductManagementPresentationModel productManagementPresentationModel)
        {
            InitializeComponent();
            // every event
            _productManagementPresentationModel = productManagementPresentationModel;
            _addNewProductButton.Click += HandleAddNewProductButtonClick;
            _productListBox.SelectedIndexChanged += HandleProductListBoxSelectedIndexChanged;
            _productNameTextBox.TextChanged += HandleProductInformationChangedEvent;
            _priceTextBox.TextChanged += HandleProductInformationChangedEvent;
            _picturePathTextBox.TextChanged += HandleProductInformationChangedEvent;
            _descriptionRichTextBox.TextChanged += HandleProductInformationChangedEvent;
            _categoryComboBox.SelectionChangeCommitted += HandleProductInformationChangedEvent;
            _button.Click += HandleButtonClick;
            _browseButton.Click += HandleBrowseButtonClick;
            _priceTextBox.KeyPress += HandleTextBoxKeyPress;
            FormClosing += HandleFormClosing;
            _productManagementPresentationModel._clearAllAdtaEvent += CleanAllData;
            // databiding
            _button.DataBindings.Add(Constant.ENABLED, _productManagementPresentationModel, IS_BUTTON_PRODUCT_SAVE_ENABLE);
            _addNewProductButton.DataBindings.Add(Constant.ENABLED, _productManagementPresentationModel, IS_BUTTON_ADD_ENABLE);
            _button.DataBindings.Add(Constant.TEXT, _productManagementPresentationModel, BUTTON_SAVE_ADD_TEXT);
            _groupBox.DataBindings.Add(Constant.TEXT, _productManagementPresentationModel, GROUP_BOX_MEAL_TEXT);
            // initialize function
            InitializeTabPage();
            RefreshListBox();
            RefreshCategoryInformation();
        }

        // handle Browse Button click ecent
        private void HandleBrowseButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            const string FILE_FORMAT_FILTER = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png| All Files (*.*) | *.*";
            openFileDialog.Filter = FILE_FORMAT_FILTER;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileName != null)
            {
                _picturePathTextBox.Text = openFileDialog.FileName;
            }
        }

        // 處理 儲存(或新增) 按鈕被點擊事件
        private void HandleButtonClick(object sender, EventArgs e)
        {
            _productManagementPresentationModel.HandleButtonClickEvent(_listBoxSelectedIndex, GetTextBoxText());
            //CleanAllData();
        }

        // 處理只能輸入純數字的 TextBox 輸入限制
        private void HandleTextBoxKeyPress(object sender, KeyPressEventArgs e)
        { 
            e.Handled = !_productManagementPresentationModel.HandleTextBoxKeyPress(e.KeyChar, (char)Keys.Back);
        }

        // Initialize TabPage
        private void InitializeTabPage()
        {
            _tabControl.TabPages.Clear();
            TabPage productManagementTabPage = new TabPage();
            productManagementTabPage.Name = productManagementTabPage.Text = Constant.PRODUCT_MANAGER;
            productManagementTabPage.Controls.Add(_tableLayoutPanel2);
            _tabControl.Controls.Add(productManagementTabPage);
            TabPage categoryManagementTabPage = new TabPage();
            categoryManagementTabPage.Name = categoryManagementTabPage.Text = Constant.CATEGORY_MANAGER;
            // 缺介面
            _tabControl.Controls.Add(categoryManagementTabPage);
        }

        // 刷新 TextBox 資訊
        private void UpdateProductInformationText(int index)
        {
            _productNameTextBox.Text = _productManagementPresentationModel.Model.ProductList[_listBoxSelectedIndex].Name;
            _priceTextBox.Text = _productManagementPresentationModel.Model.ProductList[_listBoxSelectedIndex].Price;
            _categoryComboBox.Text = _productManagementPresentationModel.Model.ProductList[_listBoxSelectedIndex].Category.Name;
            _picturePathTextBox.Text = _productManagementPresentationModel.Model.ProductList[_listBoxSelectedIndex].ImagePath;
            _descriptionRichTextBox.Text = _productManagementPresentationModel.Model.ProductList[_listBoxSelectedIndex].Description;
        }

        // 刷新 ListBox
        private void RefreshListBox()
        {
            _productListBox.Items.Clear();
            const string NAME = "Name";
            _productListBox.Items.AddRange(_productManagementPresentationModel.Model.ProductList.ToArray());
            _productListBox.DisplayMember = NAME;
        }

        // 刷新 Category 相關資訊
        private void RefreshCategoryInformation()
        {
            List<Category> categorys = _productManagementPresentationModel.Model.ProductCategory;
            _categoryComboBox.Items.Clear();
            foreach (var item in categorys)
            {
                _categoryComboBox.Items.Add(item.Name);
            }
        }

        //清除所有 groupBox 中的的各項資料
        private void CleanAllData()
        {
            _productNameTextBox.Text = string.Empty;
            _priceTextBox.Text = string.Empty;
            _priceTextBox.Text = string.Empty;
            _descriptionRichTextBox.Text = string.Empty;
            _picturePathTextBox.Text = string.Empty;
            _categoryComboBox.SelectedIndex = -1;
            _productListBox.ClearSelected();
        }

        // 取得 groupbox 中的各項文字
        private string[] GetTextBoxText()
        {
            string[] stringText = new string[Constant.FIVE];
            stringText[0] = _productNameTextBox.Text;
            stringText[1] = _priceTextBox.Text;
            stringText[Constant.TWO] = _categoryComboBox.Text;
            stringText[Constant.THREE] = _picturePathTextBox.Text;
            stringText[Constant.FOUR] = _descriptionRichTextBox.Text;
            return stringText;
        }

        // 處理 ListBox 東西被點擊
        private void HandleProductListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_productListBox.SelectedItem != null)
            {
                _listBoxSelectedIndex = _productListBox.SelectedIndex;
                UpdateProductInformationText(_listBoxSelectedIndex);
                _productManagementPresentationModel.HandleProductListBoxSelected();
            }
        }

        // 處理 "新增商品" 按鈕點擊
        private void HandleAddNewProductButtonClick(object sender, EventArgs e)
        {
            _productManagementPresentationModel.HandleNewProductAddButtonClickEvent();
            CleanAllData();
        }

        //處理 texcbox change event
        private void HandleProductInformationChangedEvent(object sender, EventArgs e)
        {
            //GetTextBoxText();
            _productManagementPresentationModel.CheckButtonIsCanEnable(GetTextBoxText());
        }

        // 處理 form 關閉前的事件
        private void HandleFormClosing(object sender, FormClosingEventArgs e)
        {
            CleanAllData();
        }
    }
}