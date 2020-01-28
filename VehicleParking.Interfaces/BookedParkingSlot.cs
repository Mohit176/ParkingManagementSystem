namespace VehicleParking.Interfaces
{
    public class BookedParkingSlot
    {
        public int ParkingLevel { get; private set; }
        public int ParkingSlot { get; private set; }
        public VehicleBase Vehicle { get; private set; }

        public BookedParkingSlot(int parkingLevel, int parkingSlot)
        {
            ParkingLevel = parkingLevel;
            ParkingSlot = ParkingSlot;            
        }


    }


}
