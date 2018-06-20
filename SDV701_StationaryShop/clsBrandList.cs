using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryWinForm
{
    [Serializable()]
    public class clsBrandList : SortedDictionary<string, clsBrand>
    {
        private const string _FileName = "stationary.dat";

        public void NewBrand(clsBrand prBrand)
        {
            if (!string.IsNullOrEmpty(prBrand.Name))
            {
                Add(prBrand.Name, prBrand);
            } else
                throw new Exception("No Brand name Entered");
        }

        public decimal GetTotalValue()
        {
            decimal lcTotal = 0;
            foreach (clsBrand lcBrand in Values)
            {
                lcTotal += lcBrand.TotalValue;
            }
            return lcTotal;
        }

        public static clsBrandList RetrieveBrandList()
        {
            clsBrandList lcBrandList;
            try
            {
                System.IO.FileStream lcFileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Open);
                BinaryFormatter lcFormatter = new BinaryFormatter();
                lcBrandList = (clsBrandList)lcFormatter.Deserialize(lcFileStream);
                lcFileStream.Close();
            } catch (Exception ex)
            {
                lcBrandList = new clsBrandList();
                throw new Exception("File Retrieve Error: " + ex.Message);
            }
            return lcBrandList;
        }

        public void Save()
        {
            System.IO.FileStream lcFileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Create);
            BinaryFormatter lcFormatter = new BinaryFormatter();
            lcFormatter.Serialize(lcFileStream, this);
            lcFileStream.Close();
        }

    }
}
