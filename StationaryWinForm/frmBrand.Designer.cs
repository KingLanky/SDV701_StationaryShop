namespace StationaryWinForm
{
    partial class frmBrand
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
            this.components = new System.ComponentModel.Container();
            this.lstStationary = new System.Windows.Forms.ListBox();
            this.cmsStationary = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateModifiedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblb = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblf = new System.Windows.Forms.Label();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.txtFounder = new System.Windows.Forms.TextBox();
            this.cmsStationary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstStationary
            // 
            this.lstStationary.ContextMenuStrip = this.cmsStationary;
            this.lstStationary.FormattingEnabled = true;
            this.lstStationary.Location = new System.Drawing.Point(12, 102);
            this.lstStationary.Name = "lstStationary";
            this.lstStationary.Size = new System.Drawing.Size(387, 95);
            this.lstStationary.TabIndex = 0;
            this.lstStationary.DoubleClick += new System.EventHandler(this.lstStationary_DoubleClick);
            // 
            // cmsStationary
            // 
            this.cmsStationary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByToolStripMenuItem});
            this.cmsStationary.Name = "cmsStationary";
            this.cmsStationary.Size = new System.Drawing.Size(112, 26);
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.dateModifiedToolStripMenuItem});
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.sortByToolStripMenuItem.Text = "Sort By";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.nameToolStripMenuItem.Text = "Name";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // dateModifiedToolStripMenuItem
            // 
            this.dateModifiedToolStripMenuItem.Name = "dateModifiedToolStripMenuItem";
            this.dateModifiedToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.dateModifiedToolStripMenuItem.Text = "Date Modified";
            this.dateModifiedToolStripMenuItem.Click += new System.EventHandler(this.dateModifiedToolStripMenuItem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 204);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Body";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 233);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(93, 233);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(324, 233);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.Location = new System.Drawing.Point(18, 14);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(44, 16);
            this.lblb.TabIndex = 9;
            this.lblb.Text = "Brand";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(93, 206);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(75, 21);
            this.cmbType.TabIndex = 2;
            // 
            // lblf
            // 
            this.lblf.AutoSize = true;
            this.lblf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblf.Location = new System.Drawing.Point(9, 47);
            this.lblf.Name = "lblf";
            this.lblf.Size = new System.Drawing.Size(53, 15);
            this.lblf.TabIndex = 12;
            this.lblf.Text = "Founder";
            // 
            // txtBrandName
            // 
            this.txtBrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandName.Location = new System.Drawing.Point(68, 11);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(156, 22);
            this.txtBrandName.TabIndex = 13;
            // 
            // txtFounder
            // 
            this.txtFounder.Location = new System.Drawing.Point(68, 47);
            this.txtFounder.Name = "txtFounder";
            this.txtFounder.ReadOnly = true;
            this.txtFounder.Size = new System.Drawing.Size(156, 20);
            this.txtFounder.TabIndex = 14;
            // 
            // frmBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 263);
            this.ControlBox = false;
            this.Controls.Add(this.txtFounder);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.lblf);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstStationary);
            this.Name = "frmBrand";
            this.Text = "Brands Stationary";
            this.cmsStationary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStationary;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ContextMenuStrip cmsStationary;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateModifiedToolStripMenuItem;
        private System.Windows.Forms.Label lblf;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.TextBox txtFounder;
    }
}