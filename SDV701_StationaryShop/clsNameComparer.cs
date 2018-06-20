using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryWinForm
{
    sealed class clsNameComparer : IComparer<clsStationary>
    {
        public static readonly clsNameComparer Instance = new clsNameComparer();

        private clsNameComparer() { }

        public int Compare(clsStationary x, clsStationary y)
        {
            clsStationary stationaryClassX = x;
            clsStationary stationaryClassY = y;
            string lcNameX = stationaryClassX.Name;
            string lcNameY = stationaryClassY.Name;

            return lcNameX.CompareTo(lcNameY);
        }
    }
}
