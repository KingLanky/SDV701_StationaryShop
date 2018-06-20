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

        public static void Run(clsAllStationary prPen)
        {
            Instance.SetDetails(prPen);
        }

        protected override void updateForm()
        {
            base.updateForm();
            //clsPen lcStationary = (clsPen)this._Stationary;
            txtColour.Text = _Stationary.InkColour;
            try
            {
                nudTip.Value = Convert.ToDecimal(_Stationary.LineWidth);
            } catch (Exception)
            {
                nudTip.Value = nudTip.Minimum;
            }
        }

        protected override void pushData()
        {
            base.pushData();
            //clsPen lcStationary = (clsPen)_Stationary;
            _Stationary.InkColour = txtColour.Text;
            _Stationary.LineWidth = nudTip.Value;
        }
    }
}
