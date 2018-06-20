namespace StationaryWinForm
{
    partial class frmPencil
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
            this.ckbMechanical = new System.Windows.Forms.CheckBox();
            this.cmbLead = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckbMechanical
            // 
            this.ckbMechanical.AutoSize = true;
            this.ckbMechanical.Location = new System.Drawing.Point(17, 168);
            this.ckbMechanical.Name = "ckbMechanical";
            this.ckbMechanical.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbMechanical.Size = new System.Drawing.Size(81, 17);
            this.ckbMechanical.TabIndex = 7;
            this.ckbMechanical.Text = "Mechanical";
            this.ckbMechanical.UseVisualStyleBackColor = true;
            this.ckbMechanical.CheckedChanged += new System.EventHandler(this.ckbMechanical_CheckedChanged);
            // 
            // cmbLead
            // 
            this.cmbLead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLead.FormattingEnabled = true;
            this.cmbLead.Location = new System.Drawing.Point(85, 191);
            this.cmbLead.Name = "cmbLead";
            this.cmbLead.Size = new System.Drawing.Size(100, 21);
            this.cmbLead.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Lead Grade";
            // 
            // frmPencil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 227);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbLead);
            this.Controls.Add(this.ckbMechanical);
            this.Name = "frmPencil";
            this.Text = "Pencil";
            this.Controls.SetChildIndex(this.ckbMechanical, 0);
            this.Controls.SetChildIndex(this.cmbLead, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbMechanical;
        private System.Windows.Forms.ComboBox cmbLead;
        private System.Windows.Forms.Label label7;
    }
}