using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleParking.Interfaces
{
    public interface IParkingLocatorProvider
    {
        //IParkingLocator LocateService(VehicleBase vehicle, IDictionary<int, LinkedList<LinkedList<LinkedListNode<IParkingSlot>>>> parkingLookup);

        IParkingLocator LocateService(VehicleBase vehicle);
    }
}
