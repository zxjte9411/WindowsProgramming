namespace Homework
{
    partial class OrderForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this._tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._groupBoxProducts = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._groupDescriptionBox = new System.Windows.Forms.GroupBox();
            this._tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._labelPrice = new System.Windows.Forms.Label();
            this._productDescriptionRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this._productTabControl = new System.Windows.Forms.TabControl();
            this._tabPage1 = new System.Windows.Forms.TabPage();
            this._tableLayoutPanelProductButton = new System.Windows.Forms.TableLayoutPanel();
            this._button0 = new System.Windows.Forms.Button();
            this._button1 = new System.Windows.Forms.Button();
            this._button2 = new System.Windows.Forms.Button();
            this._button3 = new System.Windows.Forms.Button();
            this._button4 = new System.Windows.Forms.Button();
            this._button5 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this._previousButton = new System.Windows.Forms.Button();
            this._buttonAdd = new System.Windows.Forms.Button();
            this._nextButton = new System.Windows.Forms.Button();
            this._tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this._labelOrder = new System.Windows.Forms.Label();
            this._recordDataGridView = new System.Windows.Forms.DataGridView();
            this._productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._labelTotalPrice = new System.Windows.Forms.Label();
            this._orderButton = new System.Windows.Forms.Button();
            this._tableLayoutPanel1.SuspendLayout();
            this._tableLayoutPanel2.SuspendLayout();
            this._groupBoxProducts.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this._groupDescriptionBox.SuspendLayout();
            this._tableLayoutPanel3.SuspendLayout();
            this._productTabControl.SuspendLayout();
            this._tabPage1.SuspendLayout();
            this._tableLayoutPanelProductButton.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this._tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._recordDataGridView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tableLayoutPanel1
            // 
            this._tableLayoutPanel1.ColumnCount = 2;
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel1.Controls.Add(this._tableLayoutPanel2, 0, 0);
            this._tableLayoutPanel1.Controls.Add(this._tableLayoutPanel4, 1, 0);
            this._tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel1.Name = "_tableLayoutPanel1";
            this._tableLayoutPanel1.RowCount = 1;
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 515F));
            this._tableLayoutPanel1.Size = new System.Drawing.Size(920, 515);
            this._tableLayoutPanel1.TabIndex = 0;
            // 
            // _tableLayoutPanel2
            // 
            this._tableLayoutPanel2.ColumnCount = 1;
            this._tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel2.Controls.Add(this._groupBoxProducts, 0, 0);
            this._tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this._tableLayoutPanel2.Name = "_tableLayoutPanel2";
            this._tableLayoutPanel2.RowCount = 1;
            this._tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 509F));
            this._tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 509F));
            this._tableLayoutPanel2.Size = new System.Drawing.Size(454, 509);
            this._tableLayoutPanel2.TabIndex = 0;
            // 
            // _groupBoxProducts
            // 
            this._groupBoxProducts.Controls.Add(this.tableLayoutPanel1);
            this._groupBoxProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this._groupBoxProducts.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._groupBoxProducts.Location = new System.Drawing.Point(3, 3);
            this._groupBoxProducts.Name = "_groupBoxProducts";
            this._groupBoxProducts.Size = new System.Drawing.Size(448, 503);
            this._groupBoxProducts.TabIndex = 3;
            this._groupBoxProducts.TabStop = false;
            this._groupBoxProducts.Text = "商品";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._groupDescriptionBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._productTabControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(442, 472);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _groupDescriptionBox
            // 
            this._groupDescriptionBox.Controls.Add(this._tableLayoutPanel3);
            this._groupDescriptionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._groupDescriptionBox.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._groupDescriptionBox.Location = new System.Drawing.Point(3, 262);
            this._groupDescriptionBox.Name = "_groupDescriptionBox";
            this._groupDescriptionBox.Size = new System.Drawing.Size(436, 135);
            this._groupDescriptionBox.TabIndex = 14;
            this._groupDescriptionBox.TabStop = false;
            this._groupDescriptionBox.Text = "商品介紹";
            // 
            // _tableLayoutPanel3
            // 
            this._tableLayoutPanel3.ColumnCount = 2;
            this._tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this._tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel3.Controls.Add(this._labelPrice, 0, 0);
            this._tableLayoutPanel3.Controls.Add(this._productDescriptionRichTextBox1, 0, 0);
            this._tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel3.Location = new System.Drawing.Point(3, 28);
            this._tableLayoutPanel3.Name = "_tableLayoutPanel3";
            this._tableLayoutPanel3.RowCount = 1;
            this._tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel3.Size = new System.Drawing.Size(430, 104);
            this._tableLayoutPanel3.TabIndex = 12;
            // 
            // _labelPrice
            // 
            this._labelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._labelPrice.AutoSize = true;
            this._labelPrice.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._labelPrice.Location = new System.Drawing.Point(427, 80);
            this._labelPrice.Name = "_labelPrice";
            this._labelPrice.Size = new System.Drawing.Size(0, 24);
            this._labelPrice.TabIndex = 14;
            // 
            // _productDescriptionRichTextBox1
            // 
            this._productDescriptionRichTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this._productDescriptionRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productDescriptionRichTextBox1.Font = new System.Drawing.Font("微軟正黑體 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._productDescriptionRichTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._productDescriptionRichTextBox1.Location = new System.Drawing.Point(3, 3);
            this._productDescriptionRichTextBox1.Name = "_productDescriptionRichTextBox1";
            this._productDescriptionRichTextBox1.Size = new System.Drawing.Size(280, 98);
            this._productDescriptionRichTextBox1.TabIndex = 13;
            this._productDescriptionRichTextBox1.Text = "";
            // 
            // _productTabControl
            // 
            this._productTabControl.Controls.Add(this._tabPage1);
            this._productTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productTabControl.Location = new System.Drawing.Point(3, 3);
            this._productTabControl.Name = "_productTabControl";
            this._productTabControl.SelectedIndex = 0;
            this._productTabControl.Size = new System.Drawing.Size(436, 253);
            this._productTabControl.TabIndex = 7;
            // 
            // _tabPage1
            // 
            this._tabPage1.Controls.Add(this._tableLayoutPanelProductButton);
            this._tabPage1.Location = new System.Drawing.Point(4, 33);
            this._tabPage1.Name = "_tabPage1";
            this._tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage1.Size = new System.Drawing.Size(428, 216);
            this._tabPage1.TabIndex = 0;
            this._tabPage1.Text = "_tabPage1";
            this._tabPage1.UseVisualStyleBackColor = true;
            // 
            // _tableLayoutPanelProductButton
            // 
            this._tableLayoutPanelProductButton.ColumnCount = 3;
            this._tableLayoutPanelProductButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanelProductButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanelProductButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanelProductButton.Controls.Add(this._button0, 0, 0);
            this._tableLayoutPanelProductButton.Controls.Add(this._button1, 1, 0);
            this._tableLayoutPanelProductButton.Controls.Add(this._button2, 2, 0);
            this._tableLayoutPanelProductButton.Controls.Add(this._button3, 0, 1);
            this._tableLayoutPanelProductButton.Controls.Add(this._button4, 1, 1);
            this._tableLayoutPanelProductButton.Controls.Add(this._button5, 2, 1);
            this._tableLayoutPanelProductButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanelProductButton.Location = new System.Drawing.Point(3, 3);
            this._tableLayoutPanelProductButton.Name = "_tableLayoutPanelProductButton";
            this._tableLayoutPanelProductButton.RowCount = 2;
            this._tableLayoutPanelProductButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelProductButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelProductButton.Size = new System.Drawing.Size(422, 210);
            this._tableLayoutPanelProductButton.TabIndex = 0;
            // 
            // _button0
            // 
            this._button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this._button0.Font = new System.Drawing.Font("微軟正黑體", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._button0.Location = new System.Drawing.Point(3, 3);
            this._button0.Name = "_button0";
            this._button0.Size = new System.Drawing.Size(134, 99);
            this._button0.TabIndex = 0;
            this._button0.UseVisualStyleBackColor = true;
            // 
            // _button1
            // 
            this._button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._button1.Font = new System.Drawing.Font("微軟正黑體", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._button1.Location = new System.Drawing.Point(143, 3);
            this._button1.Name = "_button1";
            this._button1.Size = new System.Drawing.Size(134, 99);
            this._button1.TabIndex = 1;
            this._button1.UseVisualStyleBackColor = true;
            // 
            // _button2
            // 
            this._button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._button2.Font = new System.Drawing.Font("微軟正黑體", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._button2.Location = new System.Drawing.Point(283, 3);
            this._button2.Name = "_button2";
            this._button2.Size = new System.Drawing.Size(136, 99);
            this._button2.TabIndex = 2;
            this._button2.UseVisualStyleBackColor = true;
            // 
            // _button3
            // 
            this._button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this._button3.Font = new System.Drawing.Font("微軟正黑體", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._button3.Location = new System.Drawing.Point(3, 108);
            this._button3.Name = "_button3";
            this._button3.Size = new System.Drawing.Size(134, 99);
            this._button3.TabIndex = 3;
            this._button3.UseVisualStyleBackColor = true;
            // 
            // _button4
            // 
            this._button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this._button4.Font = new System.Drawing.Font("微軟正黑體", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._button4.Location = new System.Drawing.Point(143, 108);
            this._button4.Name = "_button4";
            this._button4.Size = new System.Drawing.Size(134, 99);
            this._button4.TabIndex = 4;
            this._button4.UseVisualStyleBackColor = true;
            // 
            // _button5
            // 
            this._button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this._button5.Font = new System.Drawing.Font("微軟正黑體", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._button5.ForeColor = System.Drawing.Color.White;
            this._button5.Location = new System.Drawing.Point(283, 108);
            this._button5.Name = "_button5";
            this._button5.Size = new System.Drawing.Size(136, 99);
            this._button5.TabIndex = 5;
            this._button5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this._previousButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this._buttonAdd, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this._nextButton, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 403);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(436, 66);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 19;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _previousButton
            // 
            this._previousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._previousButton.Image = ((System.Drawing.Image)(resources.GetObject("_previousButton.Image")));
            this._previousButton.Location = new System.Drawing.Point(133, 23);
            this._previousButton.Name = "_previousButton";
            this._previousButton.Size = new System.Drawing.Size(80, 40);
            this._previousButton.TabIndex = 20;
            this._previousButton.UseVisualStyleBackColor = true;
            // 
            // _buttonAdd
            // 
            this._buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("_buttonAdd.Image")));
            this._buttonAdd.Location = new System.Drawing.Point(353, 23);
            this._buttonAdd.Name = "_buttonAdd";
            this._buttonAdd.Size = new System.Drawing.Size(80, 40);
            this._buttonAdd.TabIndex = 18;
            this._buttonAdd.UseVisualStyleBackColor = true;
            // 
            // _nextButton
            // 
            this._nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._nextButton.Image = ((System.Drawing.Image)(resources.GetObject("_nextButton.Image")));
            this._nextButton.Location = new System.Drawing.Point(220, 23);
            this._nextButton.Name = "_nextButton";
            this._nextButton.Size = new System.Drawing.Size(80, 40);
            this._nextButton.TabIndex = 21;
            this._nextButton.UseVisualStyleBackColor = true;
            // 
            // _tableLayoutPanel4
            // 
            this._tableLayoutPanel4.ColumnCount = 2;
            this._tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this._tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this._tableLayoutPanel4.Controls.Add(this._labelOrder, 1, 0);
            this._tableLayoutPanel4.Controls.Add(this._recordDataGridView, 1, 1);
            this._tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this._tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel4.Location = new System.Drawing.Point(463, 3);
            this._tableLayoutPanel4.Name = "_tableLayoutPanel4";
            this._tableLayoutPanel4.RowCount = 3;
            this._tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this._tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._tableLayoutPanel4.Size = new System.Drawing.Size(454, 509);
            this._tableLayoutPanel4.TabIndex = 1;
            // 
            // _labelOrder
            // 
            this._labelOrder.AutoSize = true;
            this._labelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelOrder.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._labelOrder.Location = new System.Drawing.Point(25, 0);
            this._labelOrder.Name = "_labelOrder";
            this._labelOrder.Size = new System.Drawing.Size(426, 50);
            this._labelOrder.TabIndex = 0;
            this._labelOrder.Text = "我的訂單";
            this._labelOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // _recordDataGridView
            // 
            this._recordDataGridView.AllowUserToAddRows = false;
            this._recordDataGridView.AllowUserToDeleteRows = false;
            this._recordDataGridView.AllowUserToResizeColumns = false;
            this._recordDataGridView.AllowUserToResizeRows = false;
            this._recordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._recordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._productName,
            this._productCategory,
            this._price});
            this._recordDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._recordDataGridView.Location = new System.Drawing.Point(25, 53);
            this._recordDataGridView.Name = "_recordDataGridView";
            this._recordDataGridView.RowHeadersVisible = false;
            this._recordDataGridView.RowTemplate.Height = 24;
            this._recordDataGridView.Size = new System.Drawing.Size(426, 375);
            this._recordDataGridView.TabIndex = 0;
            // 
            // _productName
            // 
            this._productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this._productName.DefaultCellStyle = dataGridViewCellStyle1;
            this._productName.HeaderText = "商品名稱";
            this._productName.Name = "_productName";
            this._productName.ReadOnly = true;
            this._productName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _productCategory
            // 
            this._productCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this._productCategory.DefaultCellStyle = dataGridViewCellStyle2;
            this._productCategory.HeaderText = "商品類別";
            this._productCategory.Name = "_productCategory";
            this._productCategory.ReadOnly = true;
            this._productCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _price
            // 
            this._price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this._price.DefaultCellStyle = dataGridViewCellStyle3;
            this._price.HeaderText = "單價";
            this._price.Name = "_price";
            this._price.ReadOnly = true;
            this._price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.88263F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.31455F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this._labelTotalPrice, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this._orderButton, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(25, 434);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(426, 72);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // _labelTotalPrice
            // 
            this._labelTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._labelTotalPrice.AutoSize = true;
            this._labelTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._labelTotalPrice.Location = new System.Drawing.Point(109, 20);
            this._labelTotalPrice.Name = "_labelTotalPrice";
            this._labelTotalPrice.Size = new System.Drawing.Size(0, 31);
            this._labelTotalPrice.TabIndex = 0;
            // 
            // _orderButton
            // 
            this._orderButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._orderButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._orderButton.Location = new System.Drawing.Point(316, 17);
            this._orderButton.Name = "_orderButton";
            this._orderButton.Size = new System.Drawing.Size(107, 37);
            this._orderButton.TabIndex = 1;
            this._orderButton.Text = "訂購";
            this._orderButton.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 515);
            this.Controls.Add(this._tableLayoutPanel1);
            this.Name = "OrderForm";
            this.Text = "訂購";
            this._tableLayoutPanel1.ResumeLayout(false);
            this._tableLayoutPanel2.ResumeLayout(false);
            this._groupBoxProducts.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this._groupDescriptionBox.ResumeLayout(false);
            this._tableLayoutPanel3.ResumeLayout(false);
            this._tableLayoutPanel3.PerformLayout();
            this._productTabControl.ResumeLayout(false);
            this._tabPage1.ResumeLayout(false);
            this._tableLayoutPanelProductButton.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this._tableLayoutPanel4.ResumeLayout(false);
            this._tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._recordDataGridView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel4;
        private System.Windows.Forms.Label _labelOrder;
        private System.Windows.Forms.DataGridView _recordDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn _productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _productCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn _price;
        private System.Windows.Forms.GroupBox _groupBoxProducts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl _productTabControl;
        private System.Windows.Forms.TabPage _tabPage1;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelProductButton;
        private System.Windows.Forms.Button _button0;
        private System.Windows.Forms.Button _button1;
        private System.Windows.Forms.Button _button2;
        private System.Windows.Forms.Button _button3;
        private System.Windows.Forms.Button _button4;
        private System.Windows.Forms.Button _button5;
        private System.Windows.Forms.GroupBox _groupDescriptionBox;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel3;
        private System.Windows.Forms.Label _labelPrice;
        private System.Windows.Forms.RichTextBox _productDescriptionRichTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button _buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _previousButton;
        private System.Windows.Forms.Button _nextButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label _labelTotalPrice;
        private System.Windows.Forms.Button _orderButton;
    }
}

