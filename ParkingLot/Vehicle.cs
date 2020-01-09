using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public abstract class Vehicle
    {
        public string LicenseNumber;
        public   SpotSize size; 

    }

    public enum SpotSize { M,L,XL}
}
