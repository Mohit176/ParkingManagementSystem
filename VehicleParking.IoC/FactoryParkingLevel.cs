using System;
using VehicleParking.Entities;
using VehicleParking.Interfaces;

namespace VehicleParking.IoC
{
    public static class FactoryParkingLevel
    {
        public static IParkingLevel Create(int numberOfLevels)
        {
            IParkingLevel parkingLevel = new ParkingLevel(numberOfLevels);

            return parkingLevel;
        }
    }
}
