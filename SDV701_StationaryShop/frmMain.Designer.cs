namespace StationaryWinForm
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstBrands = new System.Windows.Forms.ListBox();
            this.btnViewBrand = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStockValue = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stationary Brands";
            // 
            // lstBrands
            // 
            this.lstBrands.FormattingEnabled = true;
            this.lstBrands.Location = new System.Drawing.Point(15, 25);
            this.lstBrands.Name = "lstBrands";
            this.lstBrands.Size = new System.Drawing.Size(140, 108);
            this.lstBrands.TabIndex = 1;
            this.lstBrands.DoubleClick += new System.EventHandler(this.lbBrands_DoubleClick);
            // 
            // btnViewBrand
            // 
            this.btnViewBrand.Location = new System.Drawing.Point(161, 25);
            this.btnViewBrand.Name = "btnViewBrand";
            this.btnViewBrand.Size = new System.Drawing.Size(75, 23);
            this.btnViewBrand.TabIndex = 2;
            this.btnViewBrand.Text = "View Brand";
            this.btnViewBrand.UseVisualStyleBackColor = true;
            this.btnViewBrand.Click += new System.EventHandler(this.btnViewBrand_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Location = new System.Drawing.Point(161, 54);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(75, 23);
            this.btnViewOrders.TabIndex = 3;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(161, 160);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(161, 82);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Brand";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblStockValue
            // 
            this.lblStockValue.AutoSize = true;
            this.lblStockValue.Location = new System.Drawing.Point(16, 136);
            this.lblStockValue.Name = "lblStockValue";
            this.lblStockValue.Size = new System.Drawing.Size(35, 13);
            this.lblStockValue.TabIndex = 6;
            this.lblStockValue.Text = "label2";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(161, 111);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Del Brand";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 195);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblStockValue);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnViewBrand);
            this.Controls.Add(this.lstBrands);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Stationary Shop";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBrands;
        private System.Windows.Forms.Button btnViewBrand;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStockValue;
        private System.Windows.Forms.Button btnDelete;
    }
}

