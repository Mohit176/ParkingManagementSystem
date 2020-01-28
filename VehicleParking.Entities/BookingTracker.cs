using System;
using System.Collections.Generic;
using System.Text;
using VehicleParking.Interfaces;

namespace VehicleParking.Entities
{
    public class BookingTracker : IBookingTracker
    {
        private IDictionary<IParkingSlot, VehicleBase> _vehicleToSlotMap = new Dictionary<IParkingSlot, VehicleBase>();

        public IDictionary<IParkingSlot, VehicleBase> GetBookedParkings()
        {
            return _vehicleToSlotMap;
        }

        public void MarkBooked(IParkingSlot slot)
        {
            throw new NotImplementedException();
        }

        public void MarkVacant(VehicleBase vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
