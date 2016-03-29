using System;
using System.Collections;
using System.Collections.Generic;

namespace SuperLib.Collections.Hash
{
    /// <summary>
    /// HashTable with linear calculation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinearHash<T> : IEnumerable<T>
    {
        private readonly int _size ;

        private T[] _data;

        public LinearHash(int size)
        {
            _size = size;
            _data = new T[_size];
        }

        /// <summary>
        /// Insert new value in the hash table
        /// </summary>
        /// <param name="item"></param>
        public void Insert(T item)
        {
            int position = GetPosition(item);

            bool finished = false;
            int index = position;
            bool startedFromBeginning = false;

            while (!finished)
            {
                if (Equals(_data[index], default(T))) // Empty element
                {
                    _data[index] = item; // Save the value
                    finished = true; // Stop the loop
                }
                else
                {
                    index++; // Next index
                    if (index >= _size - 1) // If index is out of bound
                    {
                        if (startedFromBeginning) throw new IndexOutOfRangeException("There is not enough room"); // Only if we allready started from the beginning
                        index = 0;
                        startedFromBeginning = true;
                    }
                }
            }
        }

        /// <summary>
        /// Remove the value from the has table
        /// </summary>
        /// <param name="item"></param>
        public void Remove(T item)
        {
            int position = GetPosition(item);

            bool finished = false;
            int index = position;
            bool startedFromBeginning = false;

            while (!finished)
            {
                if (_data[index].Equals(item)) // Empty element
                {
                    _data[index] = default(T); // Set the default
                    finished = true; // Stop the loop
                }
                else
                {
                    index++; // Next index
                    if (index >= _size - 1) // If index is out of bound
                    {
                        if (startedFromBeginning) throw new IndexOutOfRangeException("There is not enough room"); // Only if we allready started from the beginning
                        index = 0;
                        startedFromBeginning = true;
                    }
                }
            }
        }

        /// <summary>
        /// Calculate the position with the hash in the bounds of the array
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        protected int GetPosition(T item)
        {
            int position = item.GetHashCode() % _size;
            return Math.Abs(position);
        }

        /// <summary>
        /// Get all values (only if not default)
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _size; i++)
            {
                if (!Equals(_data[i], default(T))) yield return _data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
