using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryWinForm
{
    [Serializable()]
    public class clsBrand
    {
        private string _Name;
        private string _Founder;

        private clsStationaryList _StationaryList;
        private clsBrandList _BrandList;

        public clsBrand() { }

        public clsBrand(clsBrandList prBrandList)
        {
            _StationaryList = new clsStationaryList();
            _BrandList = prBrandList;
        }

        public bool IsDuplicate(string prBrandName)
        {
            return _BrandList.ContainsKey(prBrandName);
        }

        public void NewBrand()
        {
            if (!string.IsNullOrEmpty(Name))
                _BrandList.Add(Name, this);
            else
                throw new Exception("No Brand name given");
        }



        public string Name { get => _Name; set => _Name = value; }
        public string Founder { get => _Founder; set => _Founder = value; }

        public decimal TotalValue{ get { return _StationaryList.GetTotalValue();}}

        public clsBrandList BrandList { get => _BrandList;}
        public clsStationaryList StationaryList { get => _StationaryList;}
    }
}
