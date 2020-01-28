using System;
using System.Collections.Generic;
using System.Text;
using VehicleParking.Entities;
using VehicleParking.Interfaces;

namespace VehicleParking.IoC
{
    // It can be replaced by IoC container 


    // Option1: It can be read from DI framework.
    // Option2: VehicleType to Vehicle concreate class mapping can be read from external configuration file
    // This class can read configuration file and instantiate lookup collection using lazy load.
    public enum VehicleType
    {
        Bike,
        Car,
        Bus
    }
    public static class FactoryVehicle
    {
        public static VehicleBase Create(VehicleType vehicleType)
        {
            VehicleBase vehicle = null;

            switch (vehicleType)
            {
                case VehicleType.Bike:
                    vehicle = new Bike();
                    break;
                case VehicleType.Car:
                    vehicle = new Car();
                    break;
                case VehicleType.Bus:
                    vehicle = new Bus();
                    break;
                default:
                    throw new Exception(String.Format("Vehicle {0} not supported", vehicleType.ToString()));
            }

            return vehicle;
        }
    }
}
