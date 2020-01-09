using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class ParkingSpot
    {
        public Vehicle vehicle;
        public SpotSize size;
        public int SpotNr;

        public bool IsFree()
        {
            if (vehicle == null)
                return true;
            else return false;
        }
    }
}
