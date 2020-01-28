using System;
using System.Collections.Generic;
using System.Text;
using VehicleParking.Entities;
using VehicleParking.Interfaces;

namespace VehicleParking.IoC
{
    // It can be replaced by IoC container 
    public static class FactoryParkingLot
    {
        public static IParkingLot Create(int numberOfParkingLevels)
        {       
                       
            IParkingLevel parkingLevel = FactoryParkingLevel.Create(numberOfParkingLevels);
            IParkingLocatorProvider parkingLocatorProvider = new ParkingLocatorProvider(parkingLevel.GetConfiguration());
            IBookingTracker bookingTracker = new BookingTracker();

            IParkingLot parkingLot = new ParkingLot(parkingLevel, parkingLocatorProvider, bookingTracker);

            return parkingLot;
        }
    }
}
