using ATC2027.ATC_Library.Clearance;
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
        public ConcurrentDictionary<Plane, byte> planeCollection;

        public CollectionRing()
        {
            planeCollection = new ConcurrentDictionary<Plane, byte>();
        }

        public void AddPlane(Plane plane)
        {
            planeCollection.Append(new KeyValuePair<Plane, byte>(plane, new byte()));
        }

        public void ApplyClearance(IClearance clearance, ref Plane plane)
        {
            plane.setClearance(clearance);
        }

        public void ClearAircraftCollection()
        {
            planeCollection.Clear();
        }

        public bool Contains(Plane plane)
        {
            return planeCollection.ContainsKey(plane);
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
            return planeCollection.Keys.ToList();
        }

        public IList<IAircraftCollectionRingItem> getAircraftCollectionRingListItemsAsList()
        {
            List<IAircraftCollectionRingItem> aircraftCollectionRingItem = [];

            foreach (var kvp in planeCollection) {
                aircraftCollectionRingItem.Add(kvp.Key.ToAirCraftCollectionRingItem());
            }

            return aircraftCollectionRingItem;
        }

        public void RemovePlane(Plane plane)
        {
            planeCollection.Remove(plane, out byte outByte);
        }
        
    }
}
