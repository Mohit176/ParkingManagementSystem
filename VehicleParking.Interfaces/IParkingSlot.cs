using System;

namespace VehicleParking.Interfaces
{
    public interface IParkingSlot
    {
        int ParkingNumber { get; }
        double Size { get; }

        bool IsOccupied { get; }

        bool MarkedOccupied(VehicleBase vehicle);
    }


}
