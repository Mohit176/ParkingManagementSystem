using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleParking.Interfaces;

namespace VehicleParking.Entities
{
    public class BikeParkingLocator : IParkingLocator
    {
        private readonly IDictionary<int, LinkedList<LinkedList<LinkedListNode<IParkingSlot>>>> _parkingLookup;

        public BikeParkingLocator(IDictionary<int, LinkedList<LinkedList<LinkedListNode<IParkingSlot>>>> parkingLookup)
        {
            _parkingLookup = parkingLookup;
        }
        public IParkingSlot LocateFreeSlots(VehicleBase vehicle)
        {
            IParkingSlot parkingSlot = null;

            foreach (var level in _parkingLookup)
            {
                parkingSlot = FindSlot(parkingSlot, level, typeof(MotorcycleSlot));

                if (parkingSlot != null)
                {
                    break;
                }
                else
                {
                    parkingSlot = FindSlot(parkingSlot, level, typeof(CompactSlot));

                    if (parkingSlot != null)
                    {
                        break;
                    }
                    else
                    {
                        parkingSlot = FindSlot(parkingSlot, level, typeof(LargeSlot));

                        if (parkingSlot != null)
                        {
                            break;
                        }
                    }
                }
            }

            return parkingSlot;
        }

        private static IParkingSlot FindSlot(IParkingSlot parkingSlot, KeyValuePair<int, LinkedList<LinkedList<LinkedListNode<IParkingSlot>>>> level, Type type)
        {
            foreach (var row in level.Value)
            {
                var node = row.FirstOrDefault(x => x.Value.GetType() == type && x.Value.IsOccupied == false);

                if (node != null)
                {
                    parkingSlot = node.Value;
                    break;
                }

            }

            return parkingSlot;
        }

    }
}
