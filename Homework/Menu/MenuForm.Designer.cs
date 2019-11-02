namespace Homework
{
    partial class MenuForm
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
            this._tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._orderSystemButton = new System.Windows.Forms.Button();
            this._inventorySystemButton = new System.Windows.Forms.Button();
            this._exitButton = new System.Windows.Forms.Button();
            this._productManageSystemButton = new System.Windows.Forms.Button();
            this._tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tableLayoutPanel1
            // 
            this._tableLayoutPanel1.ColumnCount = 1;
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel1.Controls.Add(this._orderSystemButton, 0, 0);
            this._tableLayoutPanel1.Controls.Add(this._inventorySystemButton, 0, 1);
            this._tableLayoutPanel1.Controls.Add(this._exitButton, 0, 3);
            this._tableLayoutPanel1.Controls.Add(this._productManageSystemButton, 0, 2);
            this._tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel1.Name = "_tableLayoutPanel1";
            this._tableLayoutPanel1.RowCount = 4;
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.94752F));
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.94752F));
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.94699F));
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.15796F));
            this._tableLayoutPanel1.Size = new System.Drawing.Size(685, 390);
            this._tableLayoutPanel1.TabIndex = 0;
            // 
            // _orderSystemButton
            // 
            this._orderSystemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderSystemButton.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._orderSystemButton.Location = new System.Drawing.Point(3, 3);
            this._orderSystemButton.Name = "_orderSystemButton";
            this._orderSystemButton.Size = new System.Drawing.Size(679, 106);
            this._orderSystemButton.TabIndex = 0;
            this._orderSystemButton.Text = "OrderSystem";
            this._orderSystemButton.UseVisualStyleBackColor = true;
            // 
            // _inventorySystemButton
            // 
            this._inventorySystemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._inventorySystemButton.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._inventorySystemButton.Location = new System.Drawing.Point(3, 115);
            this._inventorySystemButton.Name = "_inventorySystemButton";
            this._inventorySystemButton.Size = new System.Drawing.Size(679, 106);
            this._inventorySystemButton.TabIndex = 1;
            this._inventorySystemButton.Text = "Inventory System";
            this._inventorySystemButton.UseVisualStyleBackColor = true;
            // 
            // _exitButton
            // 
            this._exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._exitButton.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._exitButton.Location = new System.Drawing.Point(487, 339);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(195, 48);
            this._exitButton.TabIndex = 2;
            this._exitButton.Text = "Exit";
            this._exitButton.UseVisualStyleBackColor = true;
            // 
            // _productManageSystemButton
            // 
            this._productManageSystemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productManageSystemButton.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._productManageSystemButton.Location = new System.Drawing.Point(3, 227);
            this._productManageSystemButton.Name = "_productManageSystemButton";
            this._productManageSystemButton.Size = new System.Drawing.Size(679, 106);
            this._productManageSystemButton.TabIndex = 3;
            this._productManageSystemButton.Text = "Product Manage System";
            this._productManageSystemButton.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 390);
            this.Controls.Add(this._tableLayoutPanel1);
            this.Name = "MenuForm";
            this.Text = "StartUp";
            this._tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel1;
        private System.Windows.Forms.Button _orderSystemButton;
        private System.Windows.Forms.Button _inventorySystemButton;
        private System.Windows.Forms.Button _exitButton;
        private System.Windows.Forms.Button _productManageSystemButton;
    }
}