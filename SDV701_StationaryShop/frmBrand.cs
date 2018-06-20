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
    public partial class frmBrand : Form
    {
        private clsBrand _Brand;
        private clsStationaryList _StationaryList;

        private static Dictionary<clsBrand, frmBrand> _BrandFormList = new Dictionary<clsBrand, frmBrand>();

        public frmBrand()
        {
            InitializeComponent();

            //string[] items = { "Grip Roller \t Pen \t Rounded \t $12.40", "HexiHeld \t Pen \t Hexigonal \t $13.00", "Velocity    \t Pencil \t Rounded \t $7.99" };
            //lbStationary.DataSource = items;

            string[] types = { "Pen", "Pencil" };
            cmbType.DataSource = types;
            cmbType.SelectedIndex = 0;
        }

        public static void Run(clsBrand prBrand)
        {
            frmBrand lcBrandForm;
            if (!_BrandFormList.TryGetValue(prBrand, out lcBrandForm))
            {
                lcBrandForm = new frmBrand();
                _BrandFormList.Add(prBrand, lcBrandForm);
                lcBrandForm.SetDetails(prBrand);
            } else
            {
                lcBrandForm.Show();
                lcBrandForm.Activate();
            }
        }

        private void UpdateDisplay()
        {
            if (_StationaryList.SortOrder == 0)
            {
                _StationaryList.SortByName();
            } else
            {
                _StationaryList.SortByDate();
            }

            lstStationary.DataSource = null;
            lstStationary.DataSource = _StationaryList;
            lblTotal.Text = Convert.ToString(_StationaryList.GetTotalValue());
        }

        public void UpdateForm()
        {
            txtBrandName.Text = _Brand.Name;
            txtFounder.Text = _Brand.Founder;
            _StationaryList = _Brand.StationaryList;
        }

        public void SetDetails(clsBrand prBrand)
        {
            _Brand = prBrand;
            txtBrandName.Enabled = string.IsNullOrEmpty(_Brand.Name);
            UpdateForm();
            UpdateDisplay();

            Show();
        }

        private void pushData()
        {
            _Brand.Name = txtBrandName.Text;
            _Brand.Founder = txtFounder.Text;
        }

        private void editStationary()
        {
            try
            {
                _StationaryList.EditStationary(lstStationary.SelectedIndex);
                UpdateDisplay();
                frmMain.Instance.UpdateDisplay();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Might need fixing
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string lcSelectedType = cmbType.Text;
            if (!string.IsNullOrEmpty(lcSelectedType))
            {
                _StationaryList.AddStationary(lcSelectedType);
                UpdateDisplay();
                frmMain.Instance.UpdateDisplay();
            }
        }

        private void lstStationary_DoubleClick(object sender, EventArgs e)
        {
            editStationary();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editStationary();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int lcIndex = lstStationary.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _StationaryList.RemoveAt(lcIndex);
                UpdateDisplay();
                frmMain.Instance.UpdateDisplay();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isValid() == true)
                try
                {
                    pushData();
                    if (txtBrandName.Enabled)
                    {
                        _Brand.NewBrand();
                        MessageBox.Show("Artist added!", "Success");
                        frmMain.Instance.UpdateDisplay();
                        txtBrandName.Enabled = false;
                    }
                    Hide();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private Boolean isValid()
        {
            if (txtBrandName.Enabled && txtBrandName.Text != "")
                if (_Brand.IsDuplicate(txtBrandName.Text))
                {
                    MessageBox.Show("Brand with that name already exists!", "Error adding artist");
                    return false;
                } else
                    return true;
            else
                return true;
        }

        private void dateModifiedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _StationaryList.SortOrder = 1;
            UpdateDisplay();
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _StationaryList.SortOrder = 0;
            UpdateDisplay();
        }
    }
}
