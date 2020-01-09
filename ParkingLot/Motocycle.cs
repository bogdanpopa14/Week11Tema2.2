using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class Motocycle:Vehicle
    {
        public Motocycle(string Nr)
        {
            size = SpotSize.M;
            LicenseNumber = Nr;
        }
    }
}
