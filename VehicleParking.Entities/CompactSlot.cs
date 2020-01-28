﻿using VehicleParking.Interfaces;

namespace VehicleParking.Entities
{
    public class CompactSlot : IParkingSlot
    {
        public int ParkingNumber { get; private set; }
        public double Size { get; private set; }
        public bool IsOccupied { get; private set; }
        public CompactSlot(int parkingNumber)
        {          
            ParkingNumber = parkingNumber;
        }

        public bool MarkedOccupied(VehicleBase vehicle)
        {
            bool isParked = false;
            if (!IsOccupied)
            {
                if (vehicle is Bike || vehicle is Car)
                {
                    IsOccupied = true;
                    isParked = true;
                }
            }

            return isParked;
        }
    }


}
