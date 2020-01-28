using System.Collections.Generic;
using System.Linq;
using VehicleParking.Entities;

namespace VehicleParking.Interfaces
{
    public class ParkingLot : IParkingLot
    {
        private readonly IParkingLevel _dataProvider;
        private readonly IParkingLocatorProvider _parkingLocatorProvider;
        private readonly IBookingTracker _bookingTracker;

        private IDictionary<int, LinkedList<LinkedList<LinkedListNode<IParkingSlot>>>> _parkingLookup =
             new Dictionary<int, LinkedList<LinkedList<LinkedListNode<IParkingSlot>>>>();

        public ParkingLot(IParkingLevel mockDataProvider,
            IParkingLocatorProvider parkingLocatorProvider,
            IBookingTracker bookingTracker)
        {
            _dataProvider = mockDataProvider;
            _parkingLocatorProvider = parkingLocatorProvider;
            _bookingTracker = bookingTracker;
        }

        public void AllocateParkingSlot(VehicleBase vehicle, IParkingSlot parkingSlot)
        {
            parkingSlot.MarkedOccupied(vehicle);
            _bookingTracker.MarkBooked(vehicle, parkingSlot);
        }

        public void ConfigureParking()
        {
            _parkingLookup = _dataProvider.GetConfiguration();
        }

        public void DeallocateParkingSlot(VehicleBase vehicle)
        {
            _bookingTracker.MarkVacant(vehicle);
        }

        public IParkingSlot FindParking(VehicleBase vehicle)
        {
            IParkingLocator parkingLocator = _parkingLocatorProvider.LocateService(vehicle);

            IParkingSlot availableParkingSlots = parkingLocator.LocateFreeSlots(vehicle);

            return availableParkingSlots;
        }

        public IDictionary<IParkingSlot, VehicleBase> GetBookedSlots()
        {
            return _bookingTracker.GetBookedParkings();
        }
    }



}
