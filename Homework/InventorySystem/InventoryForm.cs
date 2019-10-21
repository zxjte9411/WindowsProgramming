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
    public partial class InventoryForm : Form
    {
        InventoryFormPresentationModel _inventoryFormPresentationModel;
        public InventoryForm(InventoryFormPresentationModel inventoryFormPresentationModel)
        {
            InitializeComponent();
            _inventoryFormPresentationModel = inventoryFormPresentationModel;
            RefreshStockDataGridView();
            _stockDataGridView.CellPainting += HandleCellPainting;
            _stockDataGridView.CellClick += HandleCellClickEvent;
            _inventoryFormPresentationModel._selectCellEvent += HandleCellClicked;
            _inventoryFormPresentationModel._replacementEvent += HandleCellContentClicked;
            _inventoryFormPresentationModel.Model._stockQuantityProductChangeEvent += RefreshStockDataGridView;
            FormClosing += HandleInventoryFormFormClosing;
        }

        // 處理 InventoryForm 關閉事件
        private void HandleInventoryFormFormClosing(object sender, FormClosingEventArgs e)
        {
            ClearSomeElement();
        }

        // 清理顯示元件
        private void ClearSomeElement()
        {
            _productDescriptionRichTextBox.Text = string.Empty;
            _productPictureBox.BackgroundImage = null;
            _productPictureBox.Refresh();
        }

        // 處理 cell 被點擊的事件
        private void HandleCellClickEvent(Object sender, DataGridViewCellEventArgs e)
        {
            _inventoryFormPresentationModel.HandleDataGridViewPerformance(e.RowIndex, e.ColumnIndex);
        }

        // 處理 Cell 被點擊後的動作
        private void HandleCellClicked(int rowIndex)
        {
            // 顯示被選取的產品資訊
            Product product = _inventoryFormPresentationModel.Model.ProductList[rowIndex];
            _productDescriptionRichTextBox.Text = product.Description;
            _productPictureBox.BackgroundImage = Image.FromFile(product.ImagePath);
            _productPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        // 處理補貨被點擊的動作
        private void HandleCellContentClicked(int rowIndex)
        {
            ReplacementForm replacementForm = new ReplacementForm(new ReplacementFormPresentationModel(_inventoryFormPresentationModel.Model), rowIndex);
            replacementForm.ShowDialog();    
        }

        // 刷新庫存清單
        private void RefreshStockDataGridView()
        {
            _stockDataGridView.Rows.Clear();
            foreach (var item in _inventoryFormPresentationModel.Model.ProductList)
                _stockDataGridView.Rows.Add(_inventoryFormPresentationModel.GetRowData(item));
        }

        // 畫 DataGridViewButtonColumn 的圖片
        private void HandleCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == _stockDataGridView.Columns.Count - 1)
            {
                Image image = Image.FromFile(Constant.DELIVERY_TRUCK_ICON_IMAGE_PATH);
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var width = image.Width;
                var height = image.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - width) / Constant.TWO;
                var y = e.CellBounds.Top + (e.CellBounds.Height - height) / Constant.TWO;
                e.Graphics.DrawImage(image, new Rectangle(x, y, width, height));
                e.Handled = true;
            }
        }
    }
}
