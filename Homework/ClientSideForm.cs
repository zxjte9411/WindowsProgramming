using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Homework
{
    public partial class ClientSideForm : Form
    {
        private ClientSideFormPresentationModel _clientSideFormPresentationModel;
        Button[] _productButtons;
        public ClientSideForm(ClientSideFormPresentationModel clientSideViewPresentationModel)
        {
            InitializeComponent();
            _clientSideFormPresentationModel = clientSideViewPresentationModel;
            _productButtons = new Button[Constant.BUTTON_COUNT];
            InitializeAllProductButton();
            _buttonAdd.Click += ClickButtonAdd;
            UpdateTabControl();
            _productTabControl.Selected += UpdateSelectTabPage;
            UpdateProductButtonInformation();
        }

        // 加入產品到我的商品
        private void ClickButtonAdd(Object sender, EventArgs e)
        {
            _productTabControl.SelectedTab.Controls.Clear();
            _productTabControl.SelectedTab.Controls.Add(_tableLayoutPanelProductButton);
            _clientSideFormPresentationModel.AddProduct();
            string[] row = _clientSideFormPresentationModel.GetRowData();
            _recordDataGridView.Rows.Add(row);
            ClearLabelText();
            _buttonAdd.Enabled = false;
            _labelTotalPrice.Text = _clientSideFormPresentationModel.GetTotalPriceText();
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
            string[] productCategoriesName = _clientSideFormPresentationModel.ProductCategorysName;
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
            _clientSideFormPresentationModel.CurrentPageNumber = 1;
            _clientSideFormPresentationModel.IsHavePreviousPage = false;
            UpdateProductButtonInformation();
            _productTabControl.SelectedTab.Controls.Add(_tableLayoutPanelProductButton);
            ClearLabelText();
        }
        
        // 更新產品按鈕的資訊
        private void UpdateProductButtonInformation()
        {
            Dictionary<string, string> products = _clientSideFormPresentationModel.GetCurrentPageProducts(_productTabControl.SelectedTab.Name);
            var productsList = products.ToList();
            for (int i = 0; i < Constant.BUTTON_COUNT; i++)
            {
                _productButtons[i].Name = productsList[i].Key;
                _productButtons[i].BackgroundImage = Image.FromFile(productsList[i].Value);
                _productButtons[i].BackgroundImageLayout = ImageLayout.Stretch;
                _productButtons[i].Visible = _clientSideFormPresentationModel.IsMealButtonVisible(i, _productTabControl.SelectedTab.Name);
            }
        }

        // 產品按鈕被按下要執行的動作
        private void ClickProductButton(Object sender, EventArgs e)
        {
            Button productButton = (Button)sender;
            Product product = _clientSideFormPresentationModel.GetProduct(productButton.Name);
            //Product product = _clientSideFormPresentationModel.GetProduct(productButton.Name);
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
    }
}
