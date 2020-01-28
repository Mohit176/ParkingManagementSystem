using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleParking.Interfaces
{
    public interface IParkingSlotTrackerService
    {
        void BookedParkingSlot(BookedParkingSlot bookedParkingSlot);

        IEnumerable<BookedParkingSlot> GetBookedParking();
    }
}
