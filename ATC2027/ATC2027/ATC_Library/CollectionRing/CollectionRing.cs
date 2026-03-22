using ATC2027.ATC_Library.Clearance;
using ATC2027.Forms;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ATC_Library.CollectionRing
{
    public class CollectionRing : IAircraftCollectionRing
    {
        
        public Dictionary<string, Plane> planeCollection;

        public CollectionRing()
        {
            planeCollection = new Dictionary<string, Plane>();
        }

        public void AddPlane(Plane plane)
        {

            planeCollection.Add(plane.flightNoAsStr(), plane);
        }

        public void ApplyClearance(IClearance clearance, ref Plane plane)
        {
            plane.setClearance(ref clearance);
        }

        public void ClearAircraftCollection()
        {
            planeCollection.Clear();
        }

        public bool Contains(Plane plane)
        {
            return planeCollection.ContainsKey(plane.flightNoAsStr());
        }

        public IAircraftCollectionRing fromIATA_Code(string IATA_Code)
        {
            throw new NotImplementedException();
        }

        public IAircraftCollectionRing fromICAO_Code(string ICAO_Code)
        {
            throw new NotImplementedException();
        }

        public IList<Plane> getAircraftCollection()
        {
            return planeCollection.Values.ToList();
        }

        public IList<StatusBoardItem> getAircraftCollectionRingListItemsAsList()
        {
            List<StatusBoardItem> aircraftCollectionRingItem = [];

            foreach (var kvp in planeCollection) {
                aircraftCollectionRingItem.Add(kvp.Value.toStatusBoardItem());
            }

            return aircraftCollectionRingItem;
        }

        public void RemovePlane(Plane plane)
        {
            planeCollection.Remove(plane.flightNoAsStr(), out _);
        }

        internal Plane? GetPlaneByFlightNumber(string flightNumber)
        {
            if (!planeCollection.TryGetValue(flightNumber, out Plane plane))
            {
                plane = null;
            }

            return plane;
        }

        ConcurrentDictionary<Plane, byte> IAircraftCollectionRing.getAircraftCollection()
        {
            throw new NotImplementedException();
        }
    }
}
