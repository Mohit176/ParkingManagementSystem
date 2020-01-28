using System;
using System.Collections.Generic;
using System.Text;
using VehicleParking.Entities;
using VehicleParking.Interfaces;

namespace VehicleParking.IoC
{
    public class ParkingLocatorProvider : IParkingLocatorProvider
    {
        private readonly IDictionary<int, LinkedList<LinkedList<LinkedListNode<IParkingSlot>>>> _parkingLookup;
        private IDictionary<Type, IParkingLocator> _parkingLocatorMap = new Dictionary<Type, IParkingLocator>();

        public ParkingLocatorProvider(IDictionary<int, LinkedList<LinkedList<LinkedListNode<IParkingSlot>>>> parkingLookup)
        {
            IParkingLocator bikeParkingLocator = new BikeParkingLocator(parkingLookup);
            IParkingLocator carParkingLocator = new CarParkingLocator(parkingLookup);
            IParkingLocator busParkingLocator = new BusParkingLocator(parkingLookup);

            _parkingLocatorMap.Add(typeof(Bike), bikeParkingLocator);
            _parkingLocatorMap.Add(typeof(Car), carParkingLocator);
            _parkingLocatorMap.Add(typeof(Bus), busParkingLocator);
            _parkingLookup = parkingLookup;
        }

        public IParkingLocator LocateService(VehicleBase vehicle)
        {
           return _parkingLocatorMap[vehicle.GetType()];
        }
    }
}
