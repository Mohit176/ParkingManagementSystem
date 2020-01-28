using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleParking.Interfaces
{
    public interface IParkingLocator
    {
        IParkingSlot LocateFreeSlots(VehicleBase vehicle);
    }
}
