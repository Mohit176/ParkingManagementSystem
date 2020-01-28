using System;
using System.Collections.Generic;
using System.Linq;
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

        public void MarkBooked(VehicleBase vehicle, IParkingSlot slot)
        {
            if (!_vehicleToSlotMap.ContainsKey(slot))
            {
                _vehicleToSlotMap.Add(slot, vehicle);
            }
        }

        public void MarkVacant(VehicleBase vehicle)
        {
            var matched = _vehicleToSlotMap.Single(x => x.Value == vehicle);

            if (_vehicleToSlotMap.ContainsKey(matched.Key))
            {
                _vehicleToSlotMap.Remove(matched.Key);
            }
        }
    }
}
