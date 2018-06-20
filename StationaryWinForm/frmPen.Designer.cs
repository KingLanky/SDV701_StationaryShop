namespace StationaryWinForm
{
    partial class frmPen
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
            this.nudTip = new System.Windows.Forms.NumericUpDown();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTip)).BeginInit();
            this.SuspendLayout();
            // 
            // nudTip
            // 
            this.nudTip.DecimalPlaces = 1;
            this.nudTip.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTip.Location = new System.Drawing.Point(85, 194);
            this.nudTip.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            this.nudTip.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTip.Name = "nudTip";
            this.nudTip.Size = new System.Drawing.Size(51, 20);
            this.nudTip.TabIndex = 8;
            this.nudTip.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(85, 168);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(100, 20);
            this.txtColour.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ink Colour";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Tip Width";
            // 
            // frmPen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 223);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtColour);
            this.Controls.Add(this.nudTip);
            this.Name = "frmPen";
            this.Text = "Pen";
            this.Controls.SetChildIndex(this.nudTip, 0);
            this.Controls.SetChildIndex(this.txtColour, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nudTip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudTip;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}