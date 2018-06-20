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
        protected clsAllStationary _Stationary;

        public frmStationary()
        {
            InitializeComponent();

            string[] BodyTypes = { "Round", "Hexagonal", "Triangular", "Other" };
            cmbBodyShape.DataSource = BodyTypes;
            cmbBodyShape.SelectedIndex = 0;

            //dtpModified.CustomFormat = System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortTimePattern;
            dtpModified.Format = DateTimePickerFormat.Custom;
            dtpModified.CustomFormat = "dd/MM/yyyy   hh:mm tt";
        }

        public delegate void LoadStationaryFormDelegate(clsAllStationary prStationary);
        public static Dictionary<string, Delegate> _StationarysForm = new Dictionary<string, Delegate>
        {
            { "Pen", new LoadStationaryFormDelegate(frmPen.Run) },
            { "Pencil", new LoadStationaryFormDelegate(frmPencil.Run) }
        };
        public static void DispatchStationaryForm(clsAllStationary prStationary)
        {
            _StationarysForm[prStationary.StationaryType].DynamicInvoke(prStationary);
        }

        public void SetDetails(clsAllStationary prStationary)
        {
            _Stationary = prStationary;
            updateForm();
            ShowDialog();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter a Name");
            } else
            {
                pushData();
                if (String.IsNullOrEmpty(txtID.Text))
                    MessageBox.Show(await ServiceClient.InsertStationaryAsync(_Stationary));
                else

                    MessageBox.Show(await ServiceClient.UpdateStationaryAsync(_Stationary));
                Close();
            }



        }

        protected virtual bool isValid()
        {
            return true;
        }

        protected virtual void updateForm()
        {
            if (Convert.ToString(_Stationary.StationaryID) == "0")
            {
                txtID.Text = null;
            } else
            {
                txtID.Text = Convert.ToString(_Stationary.StationaryID);
            }
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
            try
            {
                dtpModified.Value = Convert.ToDateTime(_Stationary.DateLastMod);
            } catch (Exception)
            {
                dtpModified.Value = DateTime.Now;
            }
        }

        protected virtual void pushData()
        {
            // _Stationary.StationaryID = Convert.ToInt16(txtID.Text);
            _Stationary.Name = txtName.Text;
            _Stationary.BodyShape = cmbBodyShape.Text;
            _Stationary.Price = nudPrice.Value;
            _Stationary.Quantity = Convert.ToInt16(nudQuantity.Value);
            _Stationary.DateLastMod = DateTime.Now;
        }

        //Makes sure txtID only gets Numbers
        //private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        //    {
        //        e.Handled = true;
        //    }
        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
