using System;
using System.Collections.Generic;
using System.Text;
using VehicleParking.Entities;
using VehicleParking.Interfaces;

namespace VehicleParking.IoC
{
    // It can be replaced by IoC container 
    public class FactorParkingSlot
    {
        public static IParkingSlot CreateParkingSlot(SlotTypes slotType, int parkingNumber)
        {
            IParkingSlot parkingSlot;

            switch (slotType)
            {
                case SlotTypes.Motercycle:
                    parkingSlot = new MotorcycleSlot(parkingNumber);
                    break;
                case SlotTypes.Compact:
                    parkingSlot = new CompactSlot(parkingNumber);
                    break;
                case SlotTypes.Large:
                    parkingSlot = new LargeSlot(parkingNumber);
                    break;
                default:
                    throw new Exception("Parking Slot not supported");                    
            }

            return parkingSlot;
        }
    }
}
