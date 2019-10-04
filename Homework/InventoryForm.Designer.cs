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
            this._tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._label1 = new System.Windows.Forms.Label();
            this._tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this._tableLayoutPanel1.ColumnCount = 1;
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel1.Controls.Add(this._label1, 0, 1);
            this._tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel1.Name = "tableLayoutPanel1";
            this._tableLayoutPanel1.RowCount = 3;
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this._tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this._label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._label1.AutoSize = true;
            this._label1.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._label1.Location = new System.Drawing.Point(231, 193);
            this._label1.Name = "label1";
            this._label1.Size = new System.Drawing.Size(337, 61);
            this._label1.TabIndex = 0;
            this._label1.Text = "Coming soon";
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._tableLayoutPanel1);
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this._tableLayoutPanel1.ResumeLayout(false);
            this._tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel1;
        private System.Windows.Forms.Label _label1;
    }
}