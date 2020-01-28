using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleParking.Interfaces
{
    public interface IParkingLot
    {
        void ConfigureParking();
        IParkingSlot FindParking(VehicleBase vehicle);
        void AllocateParkingSlot(VehicleBase vehicle, IParkingSlot parkingSlot);
        void DeallocateParkingSlot(VehicleBase vehicle);
        IDictionary<IParkingSlot, VehicleBase> GetBookedSlots();
    }
}
