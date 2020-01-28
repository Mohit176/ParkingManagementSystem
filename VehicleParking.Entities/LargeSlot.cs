using VehicleParking.Interfaces;

namespace VehicleParking.Entities
{
    public class LargeSlot : IParkingSlot
    {
        public int ParkingNumber { get; private set; }
        public double Size { get; private set; }
        public bool IsOccupied { get; private set; }
        public LargeSlot(int parkingNumber)
        {            
            ParkingNumber = parkingNumber;
        }
        public bool MarkedOccupied(VehicleBase vehicle)
        {
            bool isParked = false;
            if (!IsOccupied)
            {
                if (vehicle is Bike || vehicle is Car)
                {
                    IsOccupied = true;
                    isParked = true;
                }
                else
                {
                    //if 
                }
            }

            return isParked;
        }

        public bool MarkedUnoccupied(VehicleBase vehicle)
        {
            return IsOccupied = false;
        }
    }


}
