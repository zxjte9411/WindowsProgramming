using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Homework
{
    public partial class ReplacementForm : Form
    {
        private ReplacementFormPresentationModel _replacementFormPresentationModel;
        private int _rowIndex;
        public ReplacementForm(ReplacementFormPresentationModel replacementFormPresentationModel, int rowIndex)
        {
            InitializeComponent();
            _replacementFormPresentationModel = replacementFormPresentationModel;
            _confirmButton.Click += HandleConfirmButtonClick;
            _cancelButton.Click += HandleCancelButtonClick;
            _quantityTextBox.KeyPress += HandleQuantityTextBoxKeyPress;           
            _rowIndex = rowIndex;
            RefreshForm();
        }

        // 刷新 form 的顯示文字
        private void RefreshForm()
        {
            Product product = _replacementFormPresentationModel.Model.ProductList[_rowIndex];
            const string PRODUCT_NAME = "商品名稱：";
            const string PRODUCT_CATEGORY = "商品類別：";
            const string PRODUCT_PRICE = "商品單價：";
            const string PRODUCT_QUANTITY = "庫存數量：";
            _productNameLabel.Text = PRODUCT_NAME + product.Name;
            _productCategoryLabel.Text = PRODUCT_CATEGORY + product.Category.Name;
            _productPriceLabel.Text = PRODUCT_PRICE + int.Parse(product.Price).ToString(Constant.NO);
            _productQuantityLabel.Text = PRODUCT_QUANTITY + product.Quantity;
        }
        
        // 處理只能輸入純數字的 TextBox 輸入限制
        private void HandleQuantityTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((new Regex(Constant.REGEX_ONLY_NUMBER).IsMatch(e.KeyChar.ToString())) || (e.KeyChar == (char)Keys.Back));
        }

        // 處理確認按鈕事件
        private void HandleConfirmButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            _replacementFormPresentationModel.HandleStockQuantityChange(_rowIndex, _quantityTextBox.Text);
        }

        // 處理取消按鈕事件
        private void HandleCancelButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
