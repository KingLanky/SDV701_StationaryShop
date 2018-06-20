using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationaryWinForm
{
    public partial class frmStationary : Form
    {
        protected clsStationary _Stationary;

        public frmStationary()
        {
            InitializeComponent();

            string[] BodyTypes = { "Round", "Hexagonal", "Triangular", "Other" };
            cmbBodyShape.DataSource = BodyTypes;
            cmbBodyShape.SelectedIndex = 0;

            //dtpModified.Value = DateTime.Today;
        }


        public void SetDetails(clsStationary prStationary)
        {
            _Stationary = prStationary;
            updateForm();
            ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                pushData();
                Close();
            }
        }

        protected virtual bool isValid()
        {
            return true;
        }

        protected virtual void updateForm()
        {
            txtID.Text = Convert.ToString(_Stationary.ID);
            txtName.Text = _Stationary.Name;

            //Checks if there's a written value, if not, sets a default
            if (!string.IsNullOrEmpty(_Stationary.BodyShape))
            {
                cmbBodyShape.SelectedIndex = cmbBodyShape.FindStringExact(_Stationary.BodyShape);
            } else
            {
                cmbBodyShape.SelectedIndex = 0;
            }
                        
            nudPrice.Value = _Stationary.Price;
            nudQuantity.Value = _Stationary.Quantity;
            dtpModified.Value = _Stationary.LastModified;
        }

        protected virtual void pushData()
        {
            _Stationary.ID = Convert.ToInt16(txtID.Text);
            _Stationary.Name = txtName.Text;
            _Stationary.BodyShape = cmbBodyShape.Text;
            _Stationary.Price = nudPrice.Value;
            _Stationary.Quantity = Convert.ToInt16(nudQuantity.Value);
            _Stationary.LastModified = dtpModified.Value;
        }

        //Makes sure txtID only gets Numbers
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
