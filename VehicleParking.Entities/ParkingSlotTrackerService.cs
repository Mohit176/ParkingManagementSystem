using System.Collections.Generic;
using VehicleParking.Interfaces;

namespace VehicleParking.Entities
{

    public class ParkingSlotTrackerService : IParkingSlotTrackerService
    {
        private IList<BookedParkingSlot> _bookedParkings = new List<BookedParkingSlot>();

        public ParkingSlotTrackerService()
        {

        }

        public void BookedParkingSlot(BookedParkingSlot bookedParkingSlot)
        {
            _bookedParkings.Add(bookedParkingSlot);
        }

        public IEnumerable<BookedParkingSlot> GetBookedParking()
        {
            throw new System.NotImplementedException();
        }
    }



}
