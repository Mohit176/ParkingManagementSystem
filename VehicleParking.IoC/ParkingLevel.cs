using System;
using System.Collections.Generic;
using System.Text;
using VehicleParking.Interfaces;
using VehicleParking.IoC;

namespace VehicleParking.Entities
{
    public class ParkingLevel : IParkingLevel
    {
        private IDictionary<int, LinkedList<LinkedList<LinkedListNode<IParkingSlot>>>> _parkingLookup =
            new Dictionary<int, LinkedList<LinkedList<LinkedListNode<IParkingSlot>>>>();

        private readonly int numberOflevels;

        public ParkingLevel(int numberOflevels)
        {
            this.numberOflevels = numberOflevels;
        }

        public IDictionary<int, LinkedList<LinkedList<LinkedListNode<IParkingSlot>>>> GetConfiguration()
        {
            for (int i = 0; i < numberOflevels; i++)
            {
                LinkedList<LinkedList<LinkedListNode<IParkingSlot>>> level = BuildParkingLevel(numberOflevels);

                if (!_parkingLookup.ContainsKey(i))
                {
                    _parkingLookup.Add(i, level);
                }
            }            

            return _parkingLookup;
        }

        private static LinkedList<LinkedList<LinkedListNode<IParkingSlot>>> BuildParkingLevel(int parkingLevel)
        {
            var level = new LinkedList<LinkedList<LinkedListNode<IParkingSlot>>>();

            var list = new LinkedList<LinkedListNode<IParkingSlot>>();

            //Parking slot type and slot number can be read from outside.
            // option1 : from external file 
            // option2 : from database

            IParkingSlot parkingSlot1 = FactorParkingSlot.CreateParkingSlot(SlotTypes.Motercycle, 101);
            IParkingSlot parkingSlot2 = FactorParkingSlot.CreateParkingSlot(SlotTypes.Motercycle, 102);
            IParkingSlot parkingSlot3 = FactorParkingSlot.CreateParkingSlot(SlotTypes.Motercycle, 103);

            IParkingSlot parkingSlot4 = FactorParkingSlot.CreateParkingSlot(SlotTypes.Compact, 104);
            IParkingSlot parkingSlot5 = FactorParkingSlot.CreateParkingSlot(SlotTypes.Compact, 105);
            IParkingSlot parkingSlot6 = FactorParkingSlot.CreateParkingSlot(SlotTypes.Compact, 106);

            IParkingSlot parkingSlot7 = FactorParkingSlot.CreateParkingSlot(SlotTypes.Large, 107);
            IParkingSlot parkingSlot8 = FactorParkingSlot.CreateParkingSlot(SlotTypes.Large, 108);
            IParkingSlot parkingSlot9 = FactorParkingSlot.CreateParkingSlot(SlotTypes.Large, 109);
            IParkingSlot parkingSlot10 = FactorParkingSlot.CreateParkingSlot(SlotTypes.Large, 110);
            IParkingSlot parkingSlot11 = FactorParkingSlot.CreateParkingSlot(SlotTypes.Large, 111);


            LinkedListNode<IParkingSlot> slot1 = new LinkedListNode<IParkingSlot>(parkingSlot1);
            LinkedListNode<IParkingSlot> slot2 = new LinkedListNode<IParkingSlot>(parkingSlot2);
            LinkedListNode<IParkingSlot> slot3 = new LinkedListNode<IParkingSlot>(parkingSlot3);

            LinkedListNode<IParkingSlot> slot4 = new LinkedListNode<IParkingSlot>(parkingSlot4);
            LinkedListNode<IParkingSlot> slot5 = new LinkedListNode<IParkingSlot>(parkingSlot5);
            LinkedListNode<IParkingSlot> slot6 = new LinkedListNode<IParkingSlot>(parkingSlot6);

            LinkedListNode<IParkingSlot> slot7 = new LinkedListNode<IParkingSlot>(parkingSlot7);
            LinkedListNode<IParkingSlot> slot8 = new LinkedListNode<IParkingSlot>(parkingSlot8);
            LinkedListNode<IParkingSlot> slot9 = new LinkedListNode<IParkingSlot>(parkingSlot9);
            LinkedListNode<IParkingSlot> slot10 = new LinkedListNode<IParkingSlot>(parkingSlot10);
            LinkedListNode<IParkingSlot> slot11 = new LinkedListNode<IParkingSlot>(parkingSlot11);

            list.AddFirst(slot1);
            list.AddLast(slot2);
            list.AddLast(slot3);
            list.AddLast(slot4);
            list.AddLast(slot5);
            list.AddLast(slot6);
            list.AddLast(slot7);
            list.AddLast(slot8);
            list.AddLast(slot9);
            list.AddLast(slot10);
            list.AddLast(slot11);

            level.AddFirst(list);

            return level;
        }
    }
}
