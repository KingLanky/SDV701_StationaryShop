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
        //private clsStationaryList _StationaryList;

        private static Dictionary<string, frmBrand> _BrandFormList = new Dictionary<string, frmBrand>();

        public frmBrand()
        {
            InitializeComponent();

            //Setup Type picking ComboBox
            string[] types = { "Pen", "Pencil" };
            cmbType.DataSource = types;
            cmbType.SelectedIndex = 0;
        }

        public static void Run(string prBrandName)
        {
            frmBrand lcBrandForm;

            if (string.IsNullOrEmpty(prBrandName) ||
            !_BrandFormList.TryGetValue(prBrandName, out lcBrandForm))
            {
                lcBrandForm = new frmBrand();

                if (string.IsNullOrEmpty(prBrandName))
                    lcBrandForm.SetDetails(new clsBrand());
                else
                {
                    _BrandFormList.Add(prBrandName, lcBrandForm);
                    lcBrandForm.refreshFormFromDB(prBrandName);
                }
            } else
            {
                lcBrandForm.Show();
                lcBrandForm.Activate();
            }

        }

        private async void refreshFormFromDB(string prBrandName)
        {
            SetDetails(await ServiceClient.GetBrandAsync(prBrandName));
        }

        private void UpdateDisplay()
        {
            lstStationary.DataSource = null;

            if (_Brand.StationaryList != null)

                lstStationary.DataSource =  _Brand.StationaryList;
        }

        public void UpdateForm()
        {
            txtBrandName.Text = _Brand.BrandName;
            txtFounder.Text = _Brand.Founder;
            //_StationaryList = _Brand.StationaryList;
        }

        public void SetDetails(clsBrand prBrand)
        {
            _Brand = prBrand;
            txtBrandName.Enabled = string.IsNullOrEmpty(_Brand.BrandName);
            UpdateForm();
            UpdateDisplay();

            Show();
        }

        //private void pushData()
        //{
        //    _Brand.BrandName = txtBrandName.Text;
        //    _Brand.Founder = txtFounder.Text;
        //}

        private void editStationary()
        {
            try
            {
                //_StationaryList.EditStationary(lstStationary.SelectedIndex);
                frmStationary.DispatchStationaryForm(lstStationary.SelectedValue as clsAllStationary);
                UpdateDisplay();
                frmMain.Instance.UpdateDisplay();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string lcSelectedType = cmbType.Text;

            if (!string.IsNullOrEmpty(lcSelectedType)) // Magically Empty?
            {
                clsAllStationary lcStationary = clsAllStationary.NewStationary(lcSelectedType);
                if (lcStationary != null) // valid Stationary created?
                {
                    //THIS IF NOT NEEDED WHEN REMOVING BRAND ADDTION FUCNTIOALITY
                    //if (txtBrandName.Enabled) // new artist not saved?
                    //{
                    //    pushData();
                    //    await ServiceClient.InsertBrandAsync(_Brand);
                    //    txtBrandName.Enabled = false;
                    //}

                    lcStationary.BrandName = _Brand.BrandName;
                    frmStationary.DispatchStationaryForm(lcStationary);

                    if (!string.IsNullOrEmpty(lcStationary.Name)) // not cancelled?
                    {
                        refreshFormFromDB(_Brand.BrandName);
                        frmMain.Instance.UpdateDisplay();
                    }
                }
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

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int lcIndex = lstStationary.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(await ServiceClient.DeleteStationaryAsync(lstStationary.SelectedItem as clsAllStationary));
                refreshFormFromDB(_Brand.BrandName);
                frmMain.Instance.UpdateDisplay();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //pushData();
            //if (txtBrandName.Enabled)
            //{
            //    MessageBox.Show(await ServiceClient.InsertBrandAsync(_Brand));
            //    frmMain.Instance.UpdateDisplay();
            //    txtBrandName.Enabled = false;
            //} else
            //    MessageBox.Show(await ServiceClient.UpdateBrandAsync(_Brand));
            // ADD ASYNC BACK TO HEADER IF UNCOMMENTED
            Hide();
        }

        private Boolean isValid()
        {
            //if (txtBrandName.Enabled && txtBrandName.Text != "")
            //    if (_Brand.IsDuplicate(txtBrandName.Text))
            //    {
            //        MessageBox.Show("Brand with that name already exists!", "Error adding artist");
            //        return false;
            //    } else
            //        return true;
            //else
            return true;
        }

        private void dateModifiedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Brand.StationaryList = _Brand.StationaryList.OrderBy(x => x.DateLastMod).ToList();
            UpdateDisplay();
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Brand.StationaryList = _Brand.StationaryList.OrderBy(x=>x.Name).ToList();
            UpdateDisplay();
        }
    }
}
