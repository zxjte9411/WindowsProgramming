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
        private int _buttonSelectedIndex;
        public OrderForm(OrderFormPresentationModel orderFormPresentationModel)
        {
            InitializeComponent();
            _buttonSelectedIndex = -1;
            FormClosing += HandleOrderFormFormClosing;
            _orderFormPresentationModel = orderFormPresentationModel;
            _orderFormPresentationModel.CurrentPageNumber = 1;
            _orderButton.Enabled = _orderFormPresentationModel.IsOrderButtonEnable;
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
            _recordDataGridView.CellContentClick += HandleCellContentClickEvent;
            _recordDataGridView.CellValueChanged += HandleCellValueChangedEvent;
            _orderFormPresentationModel._deleteEvent += HandleRemoveProduct;
            _orderFormPresentationModel._changeQuantityEvent += HandleCellValueChanged;
            _orderFormPresentationModel.Model._overStockLimitEvent += HandleOverStockLimit;
            _orderFormPresentationModel.Model._stockQuantityProductChangeEvent += HandleQuantityChange;
            _orderFormPresentationModel.Model._backEndChangeEvent += HandleBackEndChangeEvent;
            AddDataGridViewDeleteColumn();
            _orderButton.Click += HandleOrderButton;
            RefreshDataGridView();
            _buttonAdd.Enabled = false;
        }

        // 處理後台更新事件
        private void HandleBackEndChangeEvent()
        {
            RefreshDataGridView();
            _orderFormPresentationModel.UpdatePages(_orderFormPresentationModel.Model.GetProductsOfThisCategory(_productTabControl.SelectedTab.Name).Count);
            UpdateProductButtonInformation();
            RefreshProductInformation();
            _nextButton.Enabled = _orderFormPresentationModel.IsHaveNextPage;
            _previousButton.Enabled = _orderFormPresentationModel.IsHavePreviousPage;
            _buttonAdd.Enabled = _orderFormPresentationModel.IsButtonAddEnable;
            RefreshProductInformation();
        }

        // 處理 form 關閉前的事件
        private void HandleOrderFormFormClosing(object sender, FormClosingEventArgs e)
        {
            ClearLabelText();
        }

        // 初始化 DataGridView
        private void RefreshDataGridView()
        {
            _recordDataGridView.Rows.Clear();
            List<string[]> userSelectedProduct = _orderFormPresentationModel.Model.Order.GetUserSelectProductInList();
            for (int i = 0; i < userSelectedProduct.Count(); i++)
                _recordDataGridView.Rows.Add(userSelectedProduct[i]);
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
            if (_recordDataGridView.Rows.Count > 0)
                _recordDataGridView.Rows.RemoveAt(rowIndex);
            _labelTotalPrice.Text = total;
            ClearLabelText();
        }

        // 處理刪除按鈕被按下的事件
        private void HandleCellContentClickEvent(Object sender, DataGridViewCellEventArgs e)
        {
            _orderFormPresentationModel.HandleDataGridViewPerformance(e.RowIndex, e.ColumnIndex, null);
            _orderButton.Enabled = _orderFormPresentationModel.IsOrderButtonEnable;
        }

        //處理 DataGridView 修改 CellValue 的事件
        private void HandleCellValueChangedEvent(Object sender, DataGridViewCellEventArgs e)
        {
            object valueObject = (object)_recordDataGridView[e.ColumnIndex, e.RowIndex].Value;
            _orderFormPresentationModel.HandleDataGridViewPerformance(e.RowIndex, e.ColumnIndex, valueObject);
        }

        //處理 DataGridView 修改 CellValue 的動作
        private void HandleCellValueChanged(int rowIndex, string total)
        {
            if (_recordDataGridView.Rows.Count > 0)
            {
                _recordDataGridView.Rows[rowIndex].Cells[Constant.FIVE].Value = _orderFormPresentationModel.Model.Order.GetCustomerSelectedProductSubtotal(rowIndex).ToString(Constant.NO);
                _recordDataGridView.Rows[rowIndex].Cells[Constant.FOUR].Value = _orderFormPresentationModel.Model.Order.UserSelectedProductsQuantity[rowIndex];
            }
            _labelTotalPrice.Text = _orderFormPresentationModel.GetTotalPriceText();
        }

        // 處理庫存不足時，彈出的提示視窗
        private void HandleOverStockLimit()
        {
            MessageBox.Show("庫存不足", "庫存狀態");
        }

        // 加入產品到"我的商品"
        private void ClickButtonAdd(Object sender, EventArgs e)
        {
            _orderFormPresentationModel.AddProduct();
            string[] row = _orderFormPresentationModel.GetRowData();
            _recordDataGridView.Rows.Add(row);
            _buttonAdd.Enabled = _orderFormPresentationModel.IsButtonAddEnable;
            _labelTotalPrice.Text = _orderFormPresentationModel.GetTotalPriceText();
            _orderButton.Enabled = _orderFormPresentationModel.IsOrderButtonEnable;
            ClearLabelText();
        }

        // 更新所選的 Page 資訊
        private void UpdateSelectTabPage(Object sender, EventArgs e)
        {
            ClearLabelText();
            _orderFormPresentationModel.CurrentPageNumber = 1;
            _orderFormPresentationModel.IsHavePreviousPage = _orderFormPresentationModel.IsHavePreviousPage;
            UpdateProductButtonInformation();
            UpdateButtonsState();
            _buttonAdd.Enabled = false;
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
            UpdatePageNumberDisplay();
        }

        // 產品按鈕被按下要執行的動作
        private void ClickProductButton(Object sender, EventArgs e)
        {
            _buttonSelectedIndex = ((Button)sender).TabIndex;
            RefreshProductInformation();
        }

        // 更新產品顯示資訊
        private void RefreshProductInformation()
        {
            if (_buttonSelectedIndex == -1)
                return;
            Product product = _orderFormPresentationModel.GetProduct(_productTabControl.SelectedTab.Name, _buttonSelectedIndex);
            _productDescriptionRichTextBox.Text = product.Description;
            _labelPrice.Text = Constant.PRICE + int.Parse(product.Price).ToString(Constant.NO);
            _labelQuantity.Text = Constant.STOCK_QUANTITY + product.Quantity;
            _buttonAdd.Enabled = _orderFormPresentationModel.IsButtonAddEnable && int.Parse(_orderFormPresentationModel.Model.CurrentUserSelectProduct.Quantity) > 0;
        }

        // 清除顯示文字
        private void ClearLabelText()
        {
            _productDescriptionRichTextBox.Text = string.Empty;
            _labelPrice.Text = string.Empty;
            _labelQuantity.Text = string.Empty;
            _orderFormPresentationModel.Model.CurrentUserSelectProduct = null;
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
            _buttonSelectedIndex = -1;
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
            deleteColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            (new CreditCardPaymentForm(new CreditCardPaymentPresentationModel(_orderFormPresentationModel.Model))).ShowDialog();
            _labelTotalPrice.Text = _orderFormPresentationModel.GetTotalPriceText();
            _orderButton.Enabled = _orderFormPresentationModel.IsOrderButtonEnable;
        }

        // 處理庫存數量變更時的事件
        private void HandleQuantityChange()
        {
            RefreshDataGridView();
            _labelQuantity.Text = _orderFormPresentationModel.CurrentUserSelectProductQuantity;
            _buttonAdd.Enabled = _orderFormPresentationModel.IsButtonAddEnable;
        }
    }
}