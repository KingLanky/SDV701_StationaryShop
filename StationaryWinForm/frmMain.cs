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

        //private clsBrandList _BrandList = new clsBrandList();

        private frmMain()
        {
            InitializeComponent();

            //string[] brands = { "BIC", "PaperMate", "Staedtler" };
            //lstBrands.DataSource = brands;
        }

        public static frmMain Instance { get { return frmMain._Instance; } }

        public async void UpdateDisplay()
        {
            //lstBrands.DataSource = null;
            //string[] lcDisplayList = new string[_BrandList.Count];
            //_BrandList.Keys.CopyTo(lcDisplayList, 0);
            //lstBrands.DataSource = lcDisplayList;
            //lblStockValue.Text = Convert.ToString(_BrandList.GetTotalValue());

            lstBrands.DataSource = null;

            try
            {
                lstBrands.DataSource = await ServiceClient.GetBrandNamesAsync();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check SelfHost?");
                Close();
            }
        }

        private void ViewBrand()
        {
            string lcKey;

            lcKey = Convert.ToString(lstBrands.SelectedItem);
            if (lcKey != null)
            {
                try
                {
                    frmBrand.Run(lstBrands.SelectedItem as string);
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "How did you even manage this?");
                }

            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    _BrandList = clsBrandList.RetrieveBrandList();
            //} catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "File retrieve error");
            //}

            UpdateDisplay();
        }

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        frmBrand.Run(null);
        //    } catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error adding new Brand");
        //    }
        //}

        private void lbBrands_DoubleClick(object sender, EventArgs e)
        {
            ViewBrand();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnViewBrand_Click(object sender, EventArgs e)
        {
            ViewBrand();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            frmOrders.Run();
        }
    }
}
