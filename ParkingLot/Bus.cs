using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class Bus:Vehicle
    {
        public Bus(string nr)
        {
            size = SpotSize.XL;
            LicenseNumber = nr;
        }
    }
}
