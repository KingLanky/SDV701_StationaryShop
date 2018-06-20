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
    public sealed partial class frmPencil : frmStationary
    {
        public static readonly frmPencil Instance = new frmPencil();

        private frmPencil()
        {
            InitializeComponent();

            string[] leads = { "Any", "3H", "2H", "H", "HB", "B", "2B", "3B" };
            cmbLead.DataSource = leads;
        }

        public static void Run(clsPencil prPencil)
        {
            Instance.SetDetails(prPencil);
        }

        protected override void updateForm()
        {
            base.updateForm();
            clsPencil lcStationary = (clsPencil)this._Stationary;
            ckbMechanical.Checked = lcStationary.Mechanical;

            //Checks if there's a written value, if not, sets a default
            if (!string.IsNullOrEmpty(lcStationary.LeadGrade))
            {

                cmbLead.SelectedIndex = cmbLead.FindStringExact(lcStationary.LeadGrade);
            } else
            {
                cmbLead.SelectedIndex = 4;
            }
        }

        protected override void pushData()
        {
            base.pushData();
            clsPencil lcStationary = (clsPencil)this._Stationary;
            lcStationary.Mechanical = ckbMechanical.Checked;
            lcStationary.LeadGrade = cmbLead.Text;
        }

        private void ckbMechanical_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMechanical.Checked)
            {
                cmbLead.SelectedIndex = 0;
                cmbLead.Enabled = false;
            } else
            {
                cmbLead.Enabled = true;
            }
        }
    }
}
