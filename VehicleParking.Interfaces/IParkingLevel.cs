using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleParking.Interfaces
{
    public interface IParkingLevel
    {
        IDictionary<int, LinkedList<LinkedList<LinkedListNode<IParkingSlot>>>> GetConfiguration();
    }
}
