using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Homework
{
    public partial class OrderForm : Form
    {
        private OrderFormPresentationModel _orderFormPresentationModel;
        Button[] _productButtons;
        public OrderForm(OrderFormPresentationModel clientSideViewPresentationModel)
        {
            InitializeComponent();
            _orderFormPresentationModel = clientSideViewPresentationModel;
            _productButtons = new Button[Constant.BUTTON_COUNT];
            InitializeAllProductButton();
            UpdateTabControl();
            UpdateProductButtonInformation();
            _productTabControl.Selected += UpdateSelectTabPage;
            _buttonAdd.Click += ClickButtonAdd;
            _previousButton.Click += ClickPreviousButton;
            _nextButton.Click += ClickNextButton;
            _previousButton.Enabled = _orderFormPresentationModel.IsHavePreviousPage;
            _nextButton.Enabled = _orderFormPresentationModel.IsHaveNextPage;
        }

        // 加入產品到我的商品
        private void ClickButtonAdd(Object sender, EventArgs e)
        {
            _productTabControl.SelectedTab.Controls.Clear();
            _productTabControl.SelectedTab.Controls.Add(_tableLayoutPanelProductButton);
            _orderFormPresentationModel.AddProduct();
            string[] row = _orderFormPresentationModel.GetRowData();
            _recordDataGridView.Rows.Add(row);
            ClearLabelText();
            _buttonAdd.Enabled = false;
            _labelTotalPrice.Text = _orderFormPresentationModel.GetTotalPriceText();
        }

        // 初始化產品按鈕
        private void InitializeAllProductButton()
        {
            const string BUTTON_NAME = "_button";
            for (int i = 0; i < Constant.BUTTON_COUNT; i++)
            {
                _productButtons[i] = _tableLayoutPanelProductButton.Controls.Find(BUTTON_NAME + i.ToString(), true).FirstOrDefault() as Button;
                _productButtons[i].Click += ClickProductButton;
            }
        }

        // update tabpage
        private void UpdateTabControl()
        {
            _productTabControl.TabPages.Clear();
            _buttonAdd.Enabled = false;
            string[] productCategoriesName = _orderFormPresentationModel.ProductCategorysName;
            foreach (var productCategoryName in productCategoriesName)
            {
                TabPage tabPage = new TabPage(productCategoryName);
                tabPage.Name = productCategoryName;
                _productTabControl.Controls.Add(tabPage);
            }
            _productTabControl.SelectedTab.Controls.Add(_tableLayoutPanelProductButton);
        }

        // 更新所選的 Page 資訊
        private void UpdateSelectTabPage(Object sender, EventArgs e)
        {
            _buttonAdd.Enabled = false;
            TabControl tabPage = (TabControl)sender;
            _orderFormPresentationModel.CurrentPageNumber = 1;
            _orderFormPresentationModel.IsHavePreviousPage = false;
            UpdateProductButtonInformation();
            _productTabControl.SelectedTab.Controls.Add(_tableLayoutPanelProductButton);
            
            ClearLabelText();
        }
        
        // 更新產品按鈕的資訊
        private void UpdateProductButtonInformation()
        {
            Dictionary<string, string> products = _orderFormPresentationModel.GetCurrentPageProducts(_productTabControl.SelectedTab.Name);
            var productsList = products.ToList();
            for (int i = 0; i < Constant.BUTTON_COUNT; i++)
            {
                _productButtons[i].Name = productsList[i].Key;
                _productButtons[i].BackgroundImage = Image.FromFile(productsList[i].Value);
                _productButtons[i].BackgroundImageLayout = ImageLayout.Stretch;
                _productButtons[i].Visible = _orderFormPresentationModel.IsProductButtonVisible(i, _productTabControl.SelectedTab.Name);
            }
        }

        // 產品按鈕被按下要執行的動作
        private void ClickProductButton(Object sender, EventArgs e)
        {
            Button productButton = (Button)sender;
            Product product = _orderFormPresentationModel.GetProduct(productButton.Name);
            _productDescriptionRichTextBox1.Text = product.Description;            
            _labelPrice.Text = Constant.PRICE + product.Price;
            _buttonAdd.Enabled = true;
        }

        // 清除顯示文字
        private void ClearLabelText()
        {
            _productDescriptionRichTextBox1.Text = string.Empty;
            _labelPrice.Text = string.Empty;
        }


        private void ClickPreviousButton(Object sender, EventArgs e)
        {
            _orderFormPresentationModel.GoPreviousPage();
            UpdateProductButtonInformation();
            _previousButton.Enabled = _orderFormPresentationModel.IsHavePreviousPage;
            _nextButton.Enabled = _orderFormPresentationModel.IsHaveNextPage;
            _buttonAdd.Enabled = false;
        }

        private void ClickNextButton(Object sender, EventArgs e)
        {
            _orderFormPresentationModel.GoNextPage();
            UpdateProductButtonInformation();
            _nextButton.Enabled = _orderFormPresentationModel.IsHaveNextPage;
            _previousButton.Enabled = _orderFormPresentationModel.IsHavePreviousPage;
            _buttonAdd.Enabled = false;
        }
    }
}
