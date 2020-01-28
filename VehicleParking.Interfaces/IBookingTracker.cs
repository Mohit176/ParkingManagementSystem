using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleParking.Interfaces
{
    public interface IBookingTracker
    {
        void MarkBooked(VehicleBase vehicle, IParkingSlot slot);
        void MarkVacant(VehicleBase vehicle);
        IDictionary<IParkingSlot, VehicleBase> GetBookedParkings();
    }
}
