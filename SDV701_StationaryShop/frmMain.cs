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
    public sealed partial class frmMain : Form
    {

        private static readonly frmMain _Instance = new frmMain();

        private clsBrandList _BrandList = new clsBrandList();

        private frmMain()
        {
            InitializeComponent();

            //string[] brands = { "BIC", "PaperMate", "Staedtler" };
            //lstBrands.DataSource = brands;
        }

        public static frmMain Instance { get { return frmMain._Instance; } }

        public void UpdateDisplay()
        {
            lstBrands.DataSource = null;
            string[] lcDisplayList = new string[_BrandList.Count];
            _BrandList.Keys.CopyTo(lcDisplayList, 0);
            lstBrands.DataSource = lcDisplayList;
            lblStockValue.Text = Convert.ToString(_BrandList.GetTotalValue());
        }

        private void ViewBrand()
        {
            string lcKey;

            lcKey = Convert.ToString(lstBrands.SelectedItem);
            if (lcKey != null)
            {
                try
                {
                    frmBrand.Run(_BrandList[lcKey]);
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "How did you even manage this?");
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                _BrandList = clsBrandList.RetrieveBrandList();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File retrieve error");
            }

            UpdateDisplay();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmBrand.Run(new clsBrand(_BrandList));
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding new Brand");
            }
        }

        private void lbBrands_DoubleClick(object sender, EventArgs e)
        {
            ViewBrand();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                _BrandList.Save();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Save Error");
            }
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstBrands.SelectedItem);
            if (lcKey != null && MessageBox.Show("Are you sure?", "Deleting Brand", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _BrandList.Remove(lcKey);
                    lstBrands.ClearSelected();
                    UpdateDisplay();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error deleting Brand");
                }
            }
        }


        private void btnViewBrand_Click(object sender, EventArgs e)
        {
            ViewBrand();
        }
    }
}
