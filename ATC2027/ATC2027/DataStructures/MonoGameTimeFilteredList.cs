using Microsoft.Xna.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ATC2027.DataStructures
{
    public class MonogameTimeFilteredList<T>
    {
        
        private IList<Tuple<T, TimeSpan>> _items;

        private TimeSpan _lastUpdate;
        private TimeSpan _maximumAgeOfObjectsToBeStored;

        public MonogameTimeFilteredList(TimeSpan maximumAgeOfObjectsToBeStored, IList<T>? list = null, TimeSpan? ageOfItemsInList = null)
        {
            if (list == null ^ ageOfItemsInList == null)
            {
                //xor of list being null and ageOfItemsInList being null
                if (list == null)
                    throw new ArgumentNullException(nameof(list));
                if (ageOfItemsInList == null)
                    throw new ArgumentNullException(nameof(ageOfItemsInList));
            }

            _items = new List<Tuple<T,TimeSpan>>();

            if (list != null) {
                foreach (var item in list)
                    _items.Add(Tuple.Create(item, (TimeSpan)ageOfItemsInList));
            }

            _maximumAgeOfObjectsToBeStored = maximumAgeOfObjectsToBeStored;
        }

        public T First()
        {
            try
            {
                return _items.First().Item1;
            }
            catch (InvalidOperationException ioe)
            {
                return default;
            }

        }

        public T? Last()
        {
            try
            {
                return _items.Last().Item1;
            }
            catch (InvalidOperationException ioe)
            {
                return default;
            }

        }

        public static DateTime GetDateTimeOfNow()
        {
            return DateTime.Now;
        }


        public static DateTime GetNow()
        {
            return DateTime.Now;
        }

        public IList<Tuple<T,TimeSpan>> GetItems()
        {
            return _items.ToList();
        }
        /**
         * Could be made more efficient by searching from the back and removing items until 1 item no longer needs to be removed as the list is ordered
         */
        public void UpdateDataStructure(TimeSpan? gameTimeElapsedTime = null)
        {
            if (gameTimeElapsedTime == null)
                gameTimeElapsedTime = TimeSpan.Zero;


            _items = _items.Where(x => gameTimeElapsedTime - x.Item2 <= _maximumAgeOfObjectsToBeStored).ToList();

            _lastUpdate = (TimeSpan)gameTimeElapsedTime;
        }

        public void AddItem(T item, TimeSpan ts)
        {
            _items.Add(new Tuple<T, TimeSpan>(item, ts));
        }
        /*
         * Updates the maximum age of the objects stored within the data structure. The data structure does not currently recover previously deleted objets
         */
        public void UpdateMaximumAgeOfStoredObjects(TimeSpan age)
        {
            _maximumAgeOfObjectsToBeStored = age;
        }

        public IEnumerator<Tuple<T,TimeSpan>> GetEnumerator()
        {
            var enumeration = _items.GetEnumerator();

            return _items.GetEnumerator();
        }

        public TimeSpan GetLastUpdate()
        {
            return this._lastUpdate;
        }


        public Tuple<T,TimeSpan> this[int index] => _items[index];

        public int Count => _items.Count;
    }
}