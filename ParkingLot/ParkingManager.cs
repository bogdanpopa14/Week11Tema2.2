using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class ParkingManager
    {
        private int CarCapacity = 50;
        private int BusCapacity = 10;
        private int MotoCapacity = 20;
        readonly List<ParkingSpot> CarSpots = new List<ParkingSpot>();
        readonly List<ParkingSpot> BusSpots = new List<ParkingSpot>();
        readonly List<ParkingSpot> MotoSpots = new List<ParkingSpot>();

        public void ParkVehicle(Vehicle vehicle)
        {
            if(vehicle is Car && CarSpots.Count< CarCapacity)
            {
                ParkingSpot spot = new ParkingSpot();
                spot.size = vehicle.size;
                spot.vehicle = vehicle;
                CarSpots.Add(spot);
            }
            if (vehicle is Bus && BusSpots.Count < BusCapacity)
            {
                ParkingSpot spot = new ParkingSpot();
                spot.size = vehicle.size;
                spot.vehicle = vehicle;
                BusSpots.Add(spot);
            }
            if (vehicle is Motocycle && MotoSpots.Count < MotoCapacity)
            {
                ParkingSpot spot = new ParkingSpot();
                spot.size = vehicle.size;
                spot.vehicle = vehicle;
                MotoSpots.Add(spot);
            }
        }
    }
}
