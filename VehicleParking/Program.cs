using System;
using System.Collections.Generic;
using VehicleParking.Interfaces;
using VehicleParking.IoC;

namespace VehicleParking
{
    //todo: Exception handling , this is for testing APIs
    class Program
    {
        static void Main(string[] args)
        {
            
            IParkingLot parkingLot = BuildParkingLot();

            if (parkingLot != null)
            {
                //// Configure Parking Lot with Paking Slots
                //parkingLot.ConfigureParking();

                VehicleBase vehicle = FactoryVehicle.Create(VehicleType.Bus);

                AllocateParkingSlot(vehicle, parkingLot);
            }

        }

        private static IParkingLot BuildParkingLot()
        {
            IParkingLot parkingLot = null;

            Console.WriteLine("Initialize parking lot with parking levels");
            Console.WriteLine("Please enter number of levels");

            int numberOfParkingLevels = Convert.ToInt32(Console.ReadLine());

            parkingLot = FactoryParkingLot.Create(numberOfParkingLevels);

            return parkingLot;
        }

        private static void AllocateParkingSlot(VehicleBase vehicle, IParkingLot parkingLot)
        {
            IParkingSlot availableParkingSlot = parkingLot.FindParking(vehicle);

            if(availableParkingSlot != null)
            {
                parkingLot.AllocateParkingSlot(vehicle, availableParkingSlot);
            }
        }

        private static void DeAllocateParking(VehicleBase vehicle, IParkingLot parkingLot)
        {
            parkingLot.DeallocateParkingSlot(vehicle);
        }


    }


}
