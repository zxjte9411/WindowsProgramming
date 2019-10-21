namespace Homework
{
    partial class InventoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._stockDataGridView = new System.Windows.Forms.DataGridView();
            this._productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._replacementColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this._rightTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._productImageTextLabel = new System.Windows.Forms.Label();
            this._introductionLabel = new System.Windows.Forms.Label();
            this._productDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this._productPictureBox = new System.Windows.Forms.PictureBox();
            this._titleLabel = new System.Windows.Forms.Label();
            this._dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._stockDataGridView)).BeginInit();
            this._rightTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _mainTableLayoutPanel
            // 
            this._mainTableLayoutPanel.ColumnCount = 2;
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this._mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._mainTableLayoutPanel.Controls.Add(this._stockDataGridView, 0, 1);
            this._mainTableLayoutPanel.Controls.Add(this._rightTableLayoutPanel, 1, 1);
            this._mainTableLayoutPanel.Controls.Add(this._titleLabel, 0, 0);
            this._mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._mainTableLayoutPanel.Name = "_mainTableLayoutPanel";
            this._mainTableLayoutPanel.RowCount = 2;
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this._mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._mainTableLayoutPanel.Size = new System.Drawing.Size(872, 572);
            this._mainTableLayoutPanel.TabIndex = 0;
            // 
            // _stockDataGridView
            // 
            this._stockDataGridView.AllowUserToAddRows = false;
            this._stockDataGridView.AllowUserToDeleteRows = false;
            this._stockDataGridView.AllowUserToResizeColumns = false;
            this._stockDataGridView.AllowUserToResizeRows = false;
            this._stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._stockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._productName,
            this._productCategory,
            this._productPrice,
            this._productQuantity,
            this._replacementColumn});
            this._stockDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._stockDataGridView.Location = new System.Drawing.Point(3, 88);
            this._stockDataGridView.Name = "_stockDataGridView";
            this._stockDataGridView.ReadOnly = true;
            this._stockDataGridView.RowHeadersVisible = false;
            this._stockDataGridView.RowTemplate.Height = 24;
            this._stockDataGridView.Size = new System.Drawing.Size(604, 481);
            this._stockDataGridView.TabIndex = 0;
            // 
            // _productName
            // 
            this._productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._productName.HeaderText = "商品名稱";
            this._productName.Name = "_productName";
            this._productName.ReadOnly = true;
            this._productName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _productCategory
            // 
            this._productCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._productCategory.HeaderText = "商品類別";
            this._productCategory.Name = "_productCategory";
            this._productCategory.ReadOnly = true;
            this._productCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _productPrice
            // 
            this._productPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._productPrice.HeaderText = "單價";
            this._productPrice.Name = "_productPrice";
            this._productPrice.ReadOnly = true;
            this._productPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _productQuantity
            // 
            this._productQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._productQuantity.HeaderText = "數量";
            this._productQuantity.Name = "_productQuantity";
            this._productQuantity.ReadOnly = true;
            this._productQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _replacementColumn
            // 
            this._replacementColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._replacementColumn.HeaderText = "補貨";
            this._replacementColumn.Name = "_replacementColumn";
            this._replacementColumn.ReadOnly = true;
            this._replacementColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // _rightTableLayoutPanel
            // 
            this._rightTableLayoutPanel.ColumnCount = 1;
            this._rightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._rightTableLayoutPanel.Controls.Add(this._productImageTextLabel, 0, 0);
            this._rightTableLayoutPanel.Controls.Add(this._introductionLabel, 0, 2);
            this._rightTableLayoutPanel.Controls.Add(this._productDescriptionRichTextBox, 0, 3);
            this._rightTableLayoutPanel.Controls.Add(this._productPictureBox, 0, 1);
            this._rightTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rightTableLayoutPanel.Location = new System.Drawing.Point(613, 88);
            this._rightTableLayoutPanel.Name = "_rightTableLayoutPanel";
            this._rightTableLayoutPanel.RowCount = 4;
            this._rightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._rightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._rightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._rightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._rightTableLayoutPanel.Size = new System.Drawing.Size(256, 481);
            this._rightTableLayoutPanel.TabIndex = 1;
            // 
            // _productImageTextLabel
            // 
            this._productImageTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._productImageTextLabel.AutoSize = true;
            this._productImageTextLabel.Location = new System.Drawing.Point(3, 18);
            this._productImageTextLabel.Name = "_productImageTextLabel";
            this._productImageTextLabel.Size = new System.Drawing.Size(250, 12);
            this._productImageTextLabel.TabIndex = 0;
            this._productImageTextLabel.Text = "商品圖片：";
            // 
            // _introductionLabel
            // 
            this._introductionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._introductionLabel.AutoSize = true;
            this._introductionLabel.Location = new System.Drawing.Point(3, 210);
            this._introductionLabel.Name = "_introductionLabel";
            this._introductionLabel.Size = new System.Drawing.Size(250, 12);
            this._introductionLabel.TabIndex = 1;
            this._introductionLabel.Text = "商品介紹：";
            // 
            // _productDescriptionRichTextBox
            // 
            this._productDescriptionRichTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this._productDescriptionRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productDescriptionRichTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._productDescriptionRichTextBox.Location = new System.Drawing.Point(3, 243);
            this._productDescriptionRichTextBox.Name = "_productDescriptionRichTextBox";
            this._productDescriptionRichTextBox.Size = new System.Drawing.Size(250, 235);
            this._productDescriptionRichTextBox.TabIndex = 3;
            this._productDescriptionRichTextBox.Text = "";
            // 
            // _productPictureBox
            // 
            this._productPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productPictureBox.Location = new System.Drawing.Point(3, 51);
            this._productPictureBox.Name = "_productPictureBox";
            this._productPictureBox.Size = new System.Drawing.Size(250, 138);
            this._productPictureBox.TabIndex = 4;
            this._productPictureBox.TabStop = false;
            // 
            // _titleLabel
            // 
            this._titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._titleLabel.AutoSize = true;
            this._mainTableLayoutPanel.SetColumnSpan(this._titleLabel, 2);
            this._titleLabel.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._titleLabel.Location = new System.Drawing.Point(3, 19);
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.Size = new System.Drawing.Size(866, 47);
            this._titleLabel.TabIndex = 2;
            this._titleLabel.Text = "庫存管理系統";
            this._titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _dataGridViewTextBoxColumn1
            // 
            this._dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._dataGridViewTextBoxColumn1.HeaderText = "商品名稱";
            this._dataGridViewTextBoxColumn1.Name = "_dataGridViewTextBoxColumn1";
            // 
            // _dataGridViewTextBoxColumn2
            // 
            this._dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._dataGridViewTextBoxColumn2.HeaderText = "商品類別";
            this._dataGridViewTextBoxColumn2.Name = "_dataGridViewTextBoxColumn2";
            // 
            // _dataGridViewTextBoxColumn3
            // 
            this._dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._dataGridViewTextBoxColumn3.HeaderText = "單價";
            this._dataGridViewTextBoxColumn3.Name = "_dataGridViewTextBoxColumn3";
            // 
            // _dataGridViewTextBoxColumn4
            // 
            this._dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._dataGridViewTextBoxColumn4.HeaderText = "數量";
            this._dataGridViewTextBoxColumn4.Name = "_dataGridViewTextBoxColumn4";
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 572);
            this.Controls.Add(this._mainTableLayoutPanel);
            this.Name = "InventoryForm";
            this.Text = "庫存管理系統";
            this._mainTableLayoutPanel.ResumeLayout(false);
            this._mainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._stockDataGridView)).EndInit();
            this._rightTableLayoutPanel.ResumeLayout(false);
            this._rightTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._productPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _mainTableLayoutPanel;
        private System.Windows.Forms.DataGridView _stockDataGridView;
        private System.Windows.Forms.TableLayoutPanel _rightTableLayoutPanel;
        private System.Windows.Forms.Label _productImageTextLabel;
        private System.Windows.Forms.Label _introductionLabel;
        private System.Windows.Forms.RichTextBox _productDescriptionRichTextBox;
        private System.Windows.Forms.Label _titleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn _productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _productCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn _productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn _productQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn _replacementColumn;
        private System.Windows.Forms.PictureBox _productPictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn4;
    }
}