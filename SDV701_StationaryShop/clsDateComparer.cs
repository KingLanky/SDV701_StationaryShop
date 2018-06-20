using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryWinForm
{
    public sealed class clsDateComparer : IComparer<clsStationary>
    {
        public static readonly clsDateComparer Instance = new clsDateComparer();

        private clsDateComparer() { }

        public int Compare(clsStationary x, clsStationary y)
        {
            clsStationary lcStationaryX = x;
            clsStationary lcStationaryY = y;
            DateTime lcDateX = lcStationaryX.LastModified.Date;
            DateTime lcDateY = lcStationaryY.LastModified.Date;

            return lcDateX.CompareTo(lcDateY);
        }
    }
}
