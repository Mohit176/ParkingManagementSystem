using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleParking.Interfaces;

namespace VehicleParking.Entities
{
    public class BusParkingLocator : IParkingLocator
    {
        private readonly IDictionary<int, LinkedList<LinkedList<LinkedListNode<IParkingSlot>>>> _parkingLookup;

        public BusParkingLocator(IDictionary<int, LinkedList<LinkedList<LinkedListNode<IParkingSlot>>>> parkingLookup)
        {
            this._parkingLookup = parkingLookup;
        }
        public IParkingSlot LocateFreeSlots(VehicleBase vehicle)
        {
            IParkingSlot parkingSlot = null;
            LinkedListNode<IParkingSlot> largeSlot = null;

            foreach (var level in _parkingLookup)
            {
                largeSlot = FindSlot(parkingSlot, level, typeof(LargeSlot));

                if (largeSlot != null)
                {
                    
                    // check consecutive five nodes are available or not , if available allocate parking to bus

                    //while ((largeSlot != null))
                    //{
                    //    largeSlot = largeSlot.Next;
                    //    if(!largeSlot.Value.IsOccupied)
                    //}
                        

                    break;
                }

            }

            return parkingSlot;
        }

        private static LinkedListNode<IParkingSlot> FindSlot(IParkingSlot parkingSlot, KeyValuePair<int, LinkedList<LinkedList<LinkedListNode<IParkingSlot>>>> level, Type type)
        {
            LinkedListNode<IParkingSlot> largeSlot = null;

            foreach (var row in level.Value)
            {
                largeSlot = row.FirstOrDefault(x => x.Value.GetType() == type && x.Value.IsOccupied == false);

                if (largeSlot != null)
                {
                    break;
                }
            }

            return largeSlot;
        }

    }
}
