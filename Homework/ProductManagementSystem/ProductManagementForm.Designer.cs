namespace Homework
{
    partial class ProductManagementForm
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
            this._tabControl = new System.Windows.Forms.TabControl();
            this._tabPage1 = new System.Windows.Forms.TabPage();
            this._tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._groupBox = new System.Windows.Forms.GroupBox();
            this._tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this._tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this._productNameLabel = new System.Windows.Forms.Label();
            this._productNameTextBox = new System.Windows.Forms.TextBox();
            this._tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this._productPriceLabel = new System.Windows.Forms.Label();
            this._priceTextBox = new System.Windows.Forms.TextBox();
            this._priceLabel = new System.Windows.Forms.Label();
            this._categoryLabel = new System.Windows.Forms.Label();
            this._categoryComboBox = new System.Windows.Forms.ComboBox();
            this._tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this._picturePathLabel = new System.Windows.Forms.Label();
            this._picturePathTextBox = new System.Windows.Forms.TextBox();
            this._browseButton = new System.Windows.Forms.Button();
            this._descriptionLabel = new System.Windows.Forms.Label();
            this._descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this._productListBox = new System.Windows.Forms.ListBox();
            this._addNewProductButton = new System.Windows.Forms.Button();
            this._button = new System.Windows.Forms.Button();
            this._tabPage2 = new System.Windows.Forms.TabPage();
            this._titleLabel = new System.Windows.Forms.Label();
            this._tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._tabControl.SuspendLayout();
            this._tabPage1.SuspendLayout();
            this._tableLayoutPanel2.SuspendLayout();
            this._tableLayoutPanel3.SuspendLayout();
            this._groupBox.SuspendLayout();
            this._tableLayoutPanel4.SuspendLayout();
            this._tableLayoutPanel5.SuspendLayout();
            this._tableLayoutPanel6.SuspendLayout();
            this._tableLayoutPanel7.SuspendLayout();
            this._tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._tabPage1);
            this._tabControl.Controls.Add(this._tabPage2);
            this._tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabControl.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._tabControl.Location = new System.Drawing.Point(3, 100);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(1072, 549);
            this._tabControl.TabIndex = 2;
            // 
            // _tabPage1
            // 
            this._tabPage1.Controls.Add(this._tableLayoutPanel2);
            this._tabPage1.Location = new System.Drawing.Point(4, 26);
            this._tabPage1.Name = "_tabPage1";
            this._tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage1.Size = new System.Drawing.Size(1064, 519);
            this._tabPage1.TabIndex = 0;
            this._tabPage1.Text = "商品管理";
            this._tabPage1.UseVisualStyleBackColor = true;
            // 
            // _tableLayoutPanel2
            // 
            this._tableLayoutPanel2.ColumnCount = 2;
            this._tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this._tableLayoutPanel2.Controls.Add(this._tableLayoutPanel3, 1, 0);
            this._tableLayoutPanel2.Controls.Add(this._productListBox, 0, 0);
            this._tableLayoutPanel2.Controls.Add(this._addNewProductButton, 0, 1);
            this._tableLayoutPanel2.Controls.Add(this._button, 1, 1);
            this._tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this._tableLayoutPanel2.Name = "_tableLayoutPanel2";
            this._tableLayoutPanel2.RowCount = 2;
            this._tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this._tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._tableLayoutPanel2.Size = new System.Drawing.Size(1058, 513);
            this._tableLayoutPanel2.TabIndex = 1;
            // 
            // _tableLayoutPanel3
            // 
            this._tableLayoutPanel3.ColumnCount = 1;
            this._tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel3.Controls.Add(this._groupBox, 0, 0);
            this._tableLayoutPanel3.Controls.Add(this._descriptionLabel, 0, 1);
            this._tableLayoutPanel3.Controls.Add(this._descriptionRichTextBox, 0, 2);
            this._tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel3.Location = new System.Drawing.Point(320, 3);
            this._tableLayoutPanel3.Name = "_tableLayoutPanel3";
            this._tableLayoutPanel3.RowCount = 3;
            this._tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this._tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this._tableLayoutPanel3.Size = new System.Drawing.Size(735, 455);
            this._tableLayoutPanel3.TabIndex = 0;
            // 
            // _groupBox
            // 
            this._groupBox.Controls.Add(this._tableLayoutPanel4);
            this._groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._groupBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._groupBox.Location = new System.Drawing.Point(3, 3);
            this._groupBox.Name = "_groupBox";
            this._groupBox.Size = new System.Drawing.Size(729, 221);
            this._groupBox.TabIndex = 0;
            this._groupBox.TabStop = false;
            this._groupBox.Text = "編輯商品";
            // 
            // _tableLayoutPanel4
            // 
            this._tableLayoutPanel4.ColumnCount = 1;
            this._tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tableLayoutPanel4.Controls.Add(this._tableLayoutPanel5, 0, 0);
            this._tableLayoutPanel4.Controls.Add(this._tableLayoutPanel6, 0, 1);
            this._tableLayoutPanel4.Controls.Add(this._tableLayoutPanel7, 0, 2);
            this._tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel4.Location = new System.Drawing.Point(3, 25);
            this._tableLayoutPanel4.Name = "_tableLayoutPanel4";
            this._tableLayoutPanel4.RowCount = 3;
            this._tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel4.Size = new System.Drawing.Size(723, 193);
            this._tableLayoutPanel4.TabIndex = 2;
            // 
            // _tableLayoutPanel5
            // 
            this._tableLayoutPanel5.ColumnCount = 2;
            this._tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this._tableLayoutPanel5.Controls.Add(this._productNameLabel, 0, 0);
            this._tableLayoutPanel5.Controls.Add(this._productNameTextBox, 1, 0);
            this._tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this._tableLayoutPanel5.Name = "_tableLayoutPanel5";
            this._tableLayoutPanel5.RowCount = 1;
            this._tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel5.Size = new System.Drawing.Size(717, 58);
            this._tableLayoutPanel5.TabIndex = 3;
            // 
            // _productNameLabel
            // 
            this._productNameLabel.AutoSize = true;
            this._productNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productNameLabel.Location = new System.Drawing.Point(3, 0);
            this._productNameLabel.Name = "_productNameLabel";
            this._productNameLabel.Size = new System.Drawing.Size(101, 58);
            this._productNameLabel.TabIndex = 4;
            this._productNameLabel.Text = "商品名稱(*)";
            this._productNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _productNameTextBox
            // 
            this._productNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._productNameTextBox.Location = new System.Drawing.Point(110, 14);
            this._productNameTextBox.Name = "_productNameTextBox";
            this._productNameTextBox.Size = new System.Drawing.Size(604, 29);
            this._productNameTextBox.TabIndex = 5;
            // 
            // _tableLayoutPanel6
            // 
            this._tableLayoutPanel6.ColumnCount = 5;
            this._tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.5956F));
            this._tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.803301F));
            this._tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.91884F));
            this._tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.55158F));
            this._tableLayoutPanel6.Controls.Add(this._productPriceLabel, 0, 0);
            this._tableLayoutPanel6.Controls.Add(this._priceTextBox, 1, 0);
            this._tableLayoutPanel6.Controls.Add(this._priceLabel, 2, 0);
            this._tableLayoutPanel6.Controls.Add(this._categoryLabel, 3, 0);
            this._tableLayoutPanel6.Controls.Add(this._categoryComboBox, 4, 0);
            this._tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel6.Location = new System.Drawing.Point(3, 67);
            this._tableLayoutPanel6.Name = "_tableLayoutPanel6";
            this._tableLayoutPanel6.RowCount = 1;
            this._tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel6.Size = new System.Drawing.Size(717, 58);
            this._tableLayoutPanel6.TabIndex = 4;
            // 
            // _productPriceLabel
            // 
            this._productPriceLabel.AutoSize = true;
            this._productPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productPriceLabel.Location = new System.Drawing.Point(3, 0);
            this._productPriceLabel.Name = "_productPriceLabel";
            this._productPriceLabel.Size = new System.Drawing.Size(101, 58);
            this._productPriceLabel.TabIndex = 2;
            this._productPriceLabel.Text = "商品價格(*)";
            this._productPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _priceTextBox
            // 
            this._priceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._priceTextBox.Location = new System.Drawing.Point(110, 14);
            this._priceTextBox.Name = "_priceTextBox";
            this._priceTextBox.Size = new System.Drawing.Size(149, 29);
            this._priceTextBox.TabIndex = 3;
            this._priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _priceLabel
            // 
            this._priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._priceLabel.AutoSize = true;
            this._priceLabel.Location = new System.Drawing.Point(265, 19);
            this._priceLabel.Name = "_priceLabel";
            this._priceLabel.Size = new System.Drawing.Size(57, 20);
            this._priceLabel.TabIndex = 4;
            this._priceLabel.Text = "NTD";
            // 
            // _categoryLabel
            // 
            this._categoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._categoryLabel.AutoSize = true;
            this._categoryLabel.Location = new System.Drawing.Point(328, 19);
            this._categoryLabel.Name = "_categoryLabel";
            this._categoryLabel.Size = new System.Drawing.Size(115, 20);
            this._categoryLabel.TabIndex = 5;
            this._categoryLabel.Text = "商品類別(*)";
            this._categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _categoryComboBox
            // 
            this._categoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._categoryComboBox.FormattingEnabled = true;
            this._categoryComboBox.Location = new System.Drawing.Point(449, 19);
            this._categoryComboBox.Name = "_categoryComboBox";
            this._categoryComboBox.Size = new System.Drawing.Size(265, 28);
            this._categoryComboBox.TabIndex = 6;
            // 
            // _tableLayoutPanel7
            // 
            this._tableLayoutPanel7.ColumnCount = 3;
            this._tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this._tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.64925F));
            this._tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.46905F));
            this._tableLayoutPanel7.Controls.Add(this._picturePathLabel, 0, 0);
            this._tableLayoutPanel7.Controls.Add(this._picturePathTextBox, 1, 0);
            this._tableLayoutPanel7.Controls.Add(this._browseButton, 2, 0);
            this._tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel7.Location = new System.Drawing.Point(3, 131);
            this._tableLayoutPanel7.Name = "_tableLayoutPanel7";
            this._tableLayoutPanel7.RowCount = 1;
            this._tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel7.Size = new System.Drawing.Size(717, 59);
            this._tableLayoutPanel7.TabIndex = 5;
            // 
            // _picturePathLabel
            // 
            this._picturePathLabel.AutoSize = true;
            this._picturePathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._picturePathLabel.Location = new System.Drawing.Point(3, 0);
            this._picturePathLabel.Name = "_picturePathLabel";
            this._picturePathLabel.Size = new System.Drawing.Size(122, 59);
            this._picturePathLabel.TabIndex = 3;
            this._picturePathLabel.Text = "商品圖片路徑(*)";
            this._picturePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _picturePathTextBox
            // 
            this._picturePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._picturePathTextBox.Location = new System.Drawing.Point(131, 15);
            this._picturePathTextBox.Name = "_picturePathTextBox";
            this._picturePathTextBox.Size = new System.Drawing.Size(456, 29);
            this._picturePathTextBox.TabIndex = 4;
            // 
            // _browseButton
            // 
            this._browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._browseButton.Location = new System.Drawing.Point(593, 12);
            this._browseButton.Name = "_browseButton";
            this._browseButton.Size = new System.Drawing.Size(121, 34);
            this._browseButton.TabIndex = 5;
            this._browseButton.Text = "瀏覽...";
            this._browseButton.UseVisualStyleBackColor = true;
            // 
            // _descriptionLabel
            // 
            this._descriptionLabel.AutoSize = true;
            this._descriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._descriptionLabel.Location = new System.Drawing.Point(3, 227);
            this._descriptionLabel.Name = "_descriptionLabel";
            this._descriptionLabel.Size = new System.Drawing.Size(73, 20);
            this._descriptionLabel.TabIndex = 1;
            this._descriptionLabel.Text = "商品介紹";
            // 
            // _descriptionRichTextBox
            // 
            this._descriptionRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._descriptionRichTextBox.Location = new System.Drawing.Point(3, 252);
            this._descriptionRichTextBox.Name = "_descriptionRichTextBox";
            this._descriptionRichTextBox.Size = new System.Drawing.Size(729, 200);
            this._descriptionRichTextBox.TabIndex = 2;
            this._descriptionRichTextBox.Text = "";
            // 
            // _productListBox
            // 
            this._productListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productListBox.FormattingEnabled = true;
            this._productListBox.ItemHeight = 17;
            this._productListBox.Location = new System.Drawing.Point(3, 3);
            this._productListBox.Name = "_productListBox";
            this._productListBox.Size = new System.Drawing.Size(311, 455);
            this._productListBox.TabIndex = 1;
            // 
            // _addNewProductButton
            // 
            this._addNewProductButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addNewProductButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._addNewProductButton.Location = new System.Drawing.Point(3, 464);
            this._addNewProductButton.Name = "_addNewProductButton";
            this._addNewProductButton.Size = new System.Drawing.Size(311, 46);
            this._addNewProductButton.TabIndex = 2;
            this._addNewProductButton.Text = "新增商品";
            this._addNewProductButton.UseVisualStyleBackColor = true;
            // 
            // _button
            // 
            this._button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._button.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._button.Location = new System.Drawing.Point(930, 467);
            this._button.Name = "_button";
            this._button.Size = new System.Drawing.Size(125, 43);
            this._button.TabIndex = 3;
            this._button.UseVisualStyleBackColor = true;
            // 
            // _tabPage2
            // 
            this._tabPage2.Location = new System.Drawing.Point(4, 26);
            this._tabPage2.Name = "_tabPage2";
            this._tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage2.Size = new System.Drawing.Size(1064, 519);
            this._tabPage2.TabIndex = 1;
            this._tabPage2.Text = "類別管理";
            this._tabPage2.UseVisualStyleBackColor = true;
            // 
            // _titleLabel
            // 
            this._titleLabel.AutoSize = true;
            this._titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._titleLabel.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._titleLabel.Location = new System.Drawing.Point(3, 0);
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.Size = new System.Drawing.Size(1072, 97);
            this._titleLabel.TabIndex = 1;
            this._titleLabel.Text = "商品管理系統";
            this._titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _tableLayoutPanel1
            // 
            this._tableLayoutPanel1.ColumnCount = 1;
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel1.Controls.Add(this._titleLabel, 0, 0);
            this._tableLayoutPanel1.Controls.Add(this._tabControl, 0, 1);
            this._tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel1.Name = "_tableLayoutPanel1";
            this._tableLayoutPanel1.RowCount = 2;
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this._tableLayoutPanel1.Size = new System.Drawing.Size(1078, 652);
            this._tableLayoutPanel1.TabIndex = 0;
            // 
            // ProductManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 652);
            this.Controls.Add(this._tableLayoutPanel1);
            this.Name = "ProductManagementForm";
            this.Text = "ProductManagementForm";
            this._tabControl.ResumeLayout(false);
            this._tabPage1.ResumeLayout(false);
            this._tableLayoutPanel2.ResumeLayout(false);
            this._tableLayoutPanel3.ResumeLayout(false);
            this._tableLayoutPanel3.PerformLayout();
            this._groupBox.ResumeLayout(false);
            this._tableLayoutPanel4.ResumeLayout(false);
            this._tableLayoutPanel5.ResumeLayout(false);
            this._tableLayoutPanel5.PerformLayout();
            this._tableLayoutPanel6.ResumeLayout(false);
            this._tableLayoutPanel6.PerformLayout();
            this._tableLayoutPanel7.ResumeLayout(false);
            this._tableLayoutPanel7.PerformLayout();
            this._tableLayoutPanel1.ResumeLayout(false);
            this._tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.TabPage _tabPage1;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel3;
        private System.Windows.Forms.GroupBox _groupBox;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel5;
        private System.Windows.Forms.Label _productNameLabel;
        private System.Windows.Forms.TextBox _productNameTextBox;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel6;
        private System.Windows.Forms.Label _productPriceLabel;
        private System.Windows.Forms.TextBox _priceTextBox;
        private System.Windows.Forms.Label _priceLabel;
        private System.Windows.Forms.Label _categoryLabel;
        private System.Windows.Forms.ComboBox _categoryComboBox;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel7;
        private System.Windows.Forms.Label _picturePathLabel;
        private System.Windows.Forms.TextBox _picturePathTextBox;
        private System.Windows.Forms.Button _browseButton;
        private System.Windows.Forms.Label _descriptionLabel;
        private System.Windows.Forms.ListBox _productListBox;
        private System.Windows.Forms.Button _addNewProductButton;
        private System.Windows.Forms.Button _button;
        private System.Windows.Forms.TabPage _tabPage2;
        private System.Windows.Forms.Label _titleLabel;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox _descriptionRichTextBox;
    }
}