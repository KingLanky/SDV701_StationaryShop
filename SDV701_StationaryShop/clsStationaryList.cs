using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryWinForm
{
    [Serializable()]
    public class clsStationaryList : List<clsStationary>
    {

        private byte _SortOrder;


        public void AddStationary(string prChoice)
        {
            clsStationary lcStationary = clsStationary.NewStationary(prChoice);
            if(lcStationary != null)
            {
                Add(lcStationary);
            }
        }

        public void EditStationary(int prIndex)
        {
            if (prIndex >= 0 && prIndex < this.Count)
            {
                clsStationary lcStationary = (clsStationary)this[prIndex];
                lcStationary.EditDetails();
            } else
                throw new Exception("Sorry, no item selected #" + Convert.ToString(prIndex));
        }

        public decimal GetTotalValue()
        {
            decimal lcTotal = 0;
            foreach (clsStationary lcStationary in this)
            {
                lcTotal += lcStationary.Price;
            }
            return lcTotal;
        }

        //Sort By

        public void SortByName()
        {
            Sort(clsNameComparer.Instance);
            _SortOrder = 0;
        }

        public void SortByDate()
        {
            Sort(clsDateComparer.Instance);
            _SortOrder = 1;
        }

        public byte SortOrder { get => _SortOrder; set => _SortOrder = value; }

    }
}
