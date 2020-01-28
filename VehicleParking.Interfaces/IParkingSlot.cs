using System;

namespace VehicleParking.Interfaces
{
    //todo: make it abstact class
    public interface IParkingSlot
    {
        int ParkingNumber { get; }
        double Size { get; }
        bool IsOccupied { get; }

        bool MarkedOccupied(VehicleBase vehicle);
        bool MarkedUnoccupied(VehicleBase vehicle);
    }


}
