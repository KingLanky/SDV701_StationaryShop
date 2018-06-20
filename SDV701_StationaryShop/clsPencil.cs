using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryWinForm
{
    [Serializable()]
    public class clsPencil : clsStationary
    {
        private bool _Mechanical;
        private string _LeadGrade;

        public delegate void LoadPencilFormDelegate(clsPencil prPen);
        public static LoadPencilFormDelegate LoadPencilForm;


        public override void EditDetails()
        {
            LoadPencilForm(this);
        }


        public bool Mechanical { get => _Mechanical; set => _Mechanical = value; }
        public string LeadGrade { get => _LeadGrade; set => _LeadGrade = value; }

    }
}
