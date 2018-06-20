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
    public sealed partial class frmPen : frmStationary
    {
        public static readonly frmPen Instance = new frmPen();

        private frmPen()
        {
            InitializeComponent();
        }

        public static void Run(clsPen prPen)
        {
            Instance.SetDetails(prPen);
        }

        protected override void updateForm()
        {
            base.updateForm();
            clsPen lcStationary = (clsPen)this._Stationary;
            txtColour.Text = lcStationary.InkColour;
            try
            {
            nudTip.Value = lcStationary.TipWidth;
            } catch (Exception)
            {
                nudTip.Value = nudTip.Minimum;
            }
        }

        protected override void pushData()
        {
            base.pushData();
            clsPen lcStationary = (clsPen)_Stationary;
            lcStationary.InkColour = txtColour.Text;
            lcStationary.TipWidth = nudTip.Value;
        }
    }
}
