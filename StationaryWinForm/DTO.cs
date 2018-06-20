using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryWinForm
{
    public class clsBrand
    {
        public string BrandName { get; set; }
        public string Founder { get; set; }
        public List<clsAllStationary> StationaryList { get; set;}
    }

    public class clsAllStationary
    {

        public override string ToString()
        {
            return Name + "\t" + StationaryType + "\t" + BodyShape + "\t" + DateLastMod.ToString();
        }

        public static clsAllStationary NewStationary(string prChoice)
        {
            return new clsAllStationary() { StationaryType = prChoice };
        }

        public int StationaryID { get; set; }
        public string BrandName { get; set; }
        public string StationaryType { get; set; }
        public string Name { get; set; }
        public string BodyShape { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime? DateLastMod { get; set; }
        public string InkColour { get; set; }
        public decimal? LineWidth { get; set; }
        public bool Mechanical { get; set; }
        public string LeadGrade { get; set; }
    }

    public class clsOrder
    {



        public override string ToString()
        {
            return "Order ID: \t\t" + OrderID.ToString() + "\n" +
            "Item Name: \t" + StationaryName + "\n" +
            "Brand: \t\t" + BrandName + "\n" +
            "Quantity: \t\t" + Quantity.ToString() + "\n" +
            "Order Cost: \t$" + OrderPrice.ToString("F") + "\n" +
            "Customer Name: \t" + CustomerName +"\n" +
            "Customer No. \t" + CustomerNo;
        }
        public int? OrderID { get; set; }
        public int? StationaryID { get; set; }
        public string StationaryName { get; set; }
        public string BrandName { get; set; }
        public int Quantity { get; set; }
        public decimal OrderPrice { get; set; }
        public DateTime? Date { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNo { get; set; }

    }
}
