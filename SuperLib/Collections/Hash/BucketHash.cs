using System;
using System.Collections;
using System.Collections.Generic;

namespace SuperLib.Collections.Hash
{
    /// <summary>
    /// Buckethash table
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BucketHash<T> : IEnumerable<T>
    {
        private readonly int _size;

        /// <summary>
        /// Inner array contains CArrayLists
        /// </summary>
        private CArrayList<T>[] _data;

        /// <summary>
        /// Constructor: create empty arraylists
        /// </summary>
        /// <param name="size"></param>
        public BucketHash(int size)
        {
            _size = size;
            _data = new CArrayList<T>[_size];

            for (int i = 0; i < _size; i++)
            {
                _data[i] = new CArrayList<T>();
            }
        }

        /// <summary>
        /// Insert given value
        /// </summary>
        /// <param name="item"></param>
        public void Insert(T item)
        {
            // Get the position of the item
            int position = GetPosition(item);
            // Add it to the correct bucket
            _data[position].Add(item);
        }

        /// <summary>
        /// Remove the given value
        /// </summary>
        /// <param name="item"></param>
        public void Remove(T item)
        {
            // Get the position of the value
            int position = GetPosition(item);
            // If the bucket contains the value, remove it
            if (_data[position].Contains(item))
            {
                _data[position].Remove(item);
            }
        }

        /// <summary>
        /// Get the position of the value, between the array bounds
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        protected int GetPosition(T item)
        {
            int position = item.GetHashCode() % _size;
            return Math.Abs(position);
        }

        /// <summary>
        /// Get the value of every bucket in tha table
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _size; i++)
            {
                foreach (T item in _data[i])
                {
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
