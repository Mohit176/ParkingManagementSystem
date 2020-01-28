using VehicleParking.Interfaces;

namespace VehicleParking.Entities
{
    public class MotorcycleSlot : IParkingSlot
    {
        public int ParkingNumber { get; private set; }
        public double Size { get; private set; }
        public bool IsOccupied { get; private set; }

        public MotorcycleSlot(int parkingNumber)
        {            
            ParkingNumber = parkingNumber;
        }
        public bool MarkedOccupied(VehicleBase vehicle)
        {
            bool isParked = false;

            if (!IsOccupied)
            {
                if(vehicle is Bike)
                {
                    IsOccupied = true;
                    isParked = true;
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
