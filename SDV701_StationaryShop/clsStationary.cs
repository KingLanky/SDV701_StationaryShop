using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryWinForm
{
    [Serializable()]
    public abstract class clsStationary
    {
        private int _ID;
        private string _Name;
        private string _BodyShape;
        private decimal _Price;
        private int _Quantity;
        private DateTime _LastModified = DateTime.Now;

        public clsStationary()
        {
            EditDetails();
        }

        public static readonly string FACTORY_PROMPT = "Enter Pen for Pen or Pencil for Pencil.";


        public static clsStationary NewStationary(string prChoice)
        {
            switch (prChoice.ToUpper())
            {
                case "PEN": return new clsPen();
                case "PENCIL": return new clsPencil();
                default: return null;
            }
        }

        public abstract void EditDetails();

        public override string ToString()
        {
            return _Name + "\t" + _LastModified.ToString();
        }

        public int ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string BodyShape { get => _BodyShape; set => _BodyShape = value; }
        public decimal Price { get => _Price; set => _Price = value; }
        public int Quantity { get => _Quantity; set => _Quantity = value; }
        public DateTime LastModified { get => _LastModified; set => _LastModified = value; }

    }
}
