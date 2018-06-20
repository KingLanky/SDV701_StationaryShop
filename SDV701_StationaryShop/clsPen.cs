using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryWinForm
{
    [Serializable()]
    public class clsPen : clsStationary
    {
        private string _InkColour;
        private decimal _TipWidth;

        public delegate void LoadPenFormDelegate(clsPen prPen);
        public static LoadPenFormDelegate LoadPenForm;


        public override void EditDetails()
        {
            LoadPenForm(this); 
        }

        public string InkColour { get => _InkColour; set => _InkColour = value; }
        public decimal TipWidth { get => _TipWidth; set => _TipWidth = value; }

    }
}
