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
        public OrderForm(OrderFormPresentationModel orderFormPresentationModel)
        {
            InitializeComponent();
            _orderFormPresentationModel = orderFormPresentationModel;
            RefreshDataGridView();
            _productButtons = new Button[Constant.BUTTON_COUNT];
            InitializeAllProductButton();
            InitializeTabControl();
            UpdateProductButtonInformation();
            _productTabControl.Selected += UpdateSelectTabPage;
            _buttonAdd.Click += ClickButtonAdd;
            _previousButton.Click += ClickPreviousButton;
            _nextButton.Click += ClickNextButton;
            _previousButton.Enabled = _orderFormPresentationModel.IsHavePreviousPage;
            _nextButton.Enabled = _orderFormPresentationModel.IsHaveNextPage;
            _recordDataGridView.CellPainting += HandleCellPainting;
            _recordDataGridView.CellContentClick += HandleCellClick;
            _orderFormPresentationModel._deleteEvent += HandleRemoveProduct;
            AddDataGridViewDeleteColumn();
            _orderButton.Click += HandleOrderButton;
        }

        // 初始化 DataGridView
        private void RefreshDataGridView()
        {
            _recordDataGridView.Rows.Clear();
            List<Product> userSelectedProduct = _orderFormPresentationModel.OrderFormModel.Order.UserSelectProduct;
            for (int i = 0; i < userSelectedProduct.Count(); i++)
                _recordDataGridView.Rows.Add(string.Empty, userSelectedProduct[i].Name, userSelectedProduct[i].Category.Name ,userSelectedProduct[i].Price);
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

        // initialize tab control
        private void InitializeTabControl()
        {
            _productTabControl.TabPages.Clear();
            _buttonAdd.Enabled = _orderFormPresentationModel.IsButtonAddEnable;
            string[] productCategoriesName = _orderFormPresentationModel.ProductCategorysName;
            foreach (var productCategoryName in productCategoriesName)
            {
                TabPage tabPage = new TabPage(productCategoryName);
                tabPage.Name = productCategoryName;
                _productTabControl.Controls.Add(tabPage);
            }
            _productTabControl.SelectedTab.Controls.Add(_tableLayoutPanelProductButton);
        }

        //處理刪除餐點的動作
        private void HandleRemoveProduct(int rowIndex, string total)
        {
            _recordDataGridView.Rows.RemoveAt(rowIndex);
            _labelTotalPrice.Text = total;
        }

        // 處理刪除按鈕被按下的事件
        private void HandleCellClick(Object sender, DataGridViewCellEventArgs e)
        {
            _orderFormPresentationModel.RemoveProduct(e.RowIndex, e.ColumnIndex);
        }
        
        // 加入產品到"我的商品"
        private void ClickButtonAdd(Object sender, EventArgs e)
        {
            ClearLabelText();
            _orderFormPresentationModel.AddProduct();
            string[] row = _orderFormPresentationModel.GetRowData();
            _recordDataGridView.Rows.Add(row);
            _buttonAdd.Enabled = _orderFormPresentationModel.IsButtonAddEnable;
            _labelTotalPrice.Text = _orderFormPresentationModel.GetTotalPriceText();
        }

        // 更新所選的 Page 資訊
        private void UpdateSelectTabPage(Object sender, EventArgs e)
        {
            ClearLabelText();
            _buttonAdd.Enabled = _orderFormPresentationModel.IsButtonAddEnable;
            _orderFormPresentationModel.CurrentPageNumber = 1;
            _orderFormPresentationModel.IsHavePreviousPage = _orderFormPresentationModel.IsHavePreviousPage;
            UpdateProductButtonInformation();
            _productTabControl.SelectedTab.Controls.Add(_tableLayoutPanelProductButton);
        }
        
        // 更新產品按鈕的資訊
        private void UpdateProductButtonInformation()
        {
            for (int i = 0; i < Constant.BUTTON_COUNT; i++)
            { 
                _productButtons[i].BackgroundImage = Image.FromFile(_orderFormPresentationModel.GetCurrentPageProductsImagePath(_productTabControl.SelectedTab.Name)[i]);
                _productButtons[i].BackgroundImageLayout = ImageLayout.Stretch;
                _productButtons[i].Visible = _orderFormPresentationModel.IsProductButtonVisible(i, _productTabControl.SelectedTab.Name);
            }
            UpdateButtonsState();
            UpdatePageNumberDisplay();
        }

        // 產品按鈕被按下要執行的動作
        private void ClickProductButton(Object sender, EventArgs e)
        {
            Product product = _orderFormPresentationModel.GetProduct(_productTabControl.SelectedTab.Name, ((Button)sender).TabIndex);
            _productDescriptionRichTextBox1.Text = product.Description;            
            _labelPrice.Text = Constant.PRICE + product.Price;
            _buttonAdd.Enabled = _orderFormPresentationModel.IsButtonAddEnable;
        }

        // 清除顯示文字
        private void ClearLabelText()
        {
            _productDescriptionRichTextBox1.Text = string.Empty;
            _labelPrice.Text = string.Empty;
        }

        // go previous page
        private void ClickPreviousButton(Object sender, EventArgs e)
        {
            _orderFormPresentationModel.GoPreviousPage();
            UpdateProductButtonInformation();
            UpdateButtonsState();
            UpdatePageNumberDisplay();
        }

        // go next page
        private void ClickNextButton(Object sender, EventArgs e)
        {
            _orderFormPresentationModel.GoNextPage();
            UpdateProductButtonInformation();
            UpdateButtonsState();
            UpdatePageNumberDisplay();
        }

        // 更新按鈕狀態 並清除價格及描述文字
        private void UpdateButtonsState()
        {
            _nextButton.Enabled = _orderFormPresentationModel.IsHaveNextPage;
            _previousButton.Enabled = _orderFormPresentationModel.IsHavePreviousPage;
            _buttonAdd.Enabled = _orderFormPresentationModel.IsButtonAddEnable;
            ClearLabelText();
        }

        // 更新顯示的頁碼狀態
        private void UpdatePageNumberDisplay()
        {
            _pagesLabel.Text = Constant.PAGE + _orderFormPresentationModel.GetPageNumberText();
        }

        //add delete column
        private void AddDataGridViewDeleteColumn()
        {
            const string DELETE_TEXT = "刪除";
            const string DELETE_NAME = "deleteColumn";
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = DELETE_TEXT;
            deleteColumn.Name = DELETE_NAME;
            deleteColumn.UseColumnTextForButtonValue = true;
            _recordDataGridView.Columns.Insert(0, deleteColumn);
        }

        // 畫 DataGridViewButtonColumn 的圖片
        private void HandleCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                Image image = Image.FromFile(Constant.DELETE_BUTTON_ICON_IMAGE_PATH);
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var width = image.Width / Constant.TWO;
                var height = image.Height / Constant.TWO;
                var x = e.CellBounds.Left + (e.CellBounds.Width - width) / Constant.TWO;
                var y = e.CellBounds.Top + (e.CellBounds.Height - height) / Constant.TWO;
                e.Graphics.DrawImage(image, new Rectangle(x, y, width, height));
                e.Handled = true;
                _recordDataGridView.Columns[0].Width = image.Width * Constant.TWO;
            }
        }

        // 處理訂購事件
        private void HandleOrderButton(Object sender, EventArgs e)
        {
            (new CreditCardPaymentForm(new CreditCardPaymentPresentationModel(_orderFormPresentationModel.OrderFormModel))).ShowDialog();
            RefreshDataGridView();
            _labelTotalPrice.Text = _orderFormPresentationModel.GetTotalPriceText();
        }
    }
}