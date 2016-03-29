using System;
using System.Collections;
using System.Collections.Generic;

namespace SuperLib.Collections.Hash
{
    /// <summary>
    /// Hash the date and save it in an array.
    /// If there is allready an item, calculate new position with quadratic formula
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QuadraticHash<T> : IEnumerable<T>
    {
        private readonly int _size;

        private T[] _data;

        public QuadraticHash(int size)
        {
            _size = size;
            _data = new T[_size];
        }

        /// <summary>
        /// Insert the given value in the table
        /// </summary>
        /// <param name="item"></param>
        public void Insert(T item)
        {
            // Get the position for the given item
            int position = GetPosition(item);

            // Init variable
            bool finished = false;
            int index = position;
            int tries = 0;
            bool startedFromBeginning = false;

            while (!finished)
            {
                if (Equals(_data[index], default(T))) // Empty element
                {
                    _data[index] = item; // Save it and stop
                    finished = true;
                }
                else
                {
                    tries++; // Increase tries
                    index = 2 * tries - 1; // Calculate new index
                    if (index >= _size - 1) // If index is out of bound
                    {
                        if (startedFromBeginning) throw new IndexOutOfRangeException("No space found"); // Only if we allready started from the beginning
                        index = 1;
                        startedFromBeginning = true;
                    }
                }
            }
        }

        /// <summary>
        /// Remove the given value from the table
        /// </summary>
        /// <param name="item"></param>
        public void Remove(T item)
        {
            int position = GetPosition(item);

            bool finished = false;
            int index = position;
            int tries = 0;
            bool startedFromBeginning = false;

            while (!finished)
            {
                if (_data[index].Equals(item)) // Empty element
                {
                    _data[index] = default(T);
                    finished = true;
                }
                else
                {
                    tries++;
                    index = 2 * tries - 1;
                    if (index >= _size - 1) // If index is out of bound
                    {
                        if (startedFromBeginning) throw new IndexOutOfRangeException("No space found"); // Only if we allready started from the beginning
                        index = 1;
                        startedFromBeginning = true;
                    }
                }
            }
        }

        /// <summary>
        /// Get the hashed position of an element (in the bounds of size)
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        protected int GetPosition(T item)
        {
            int position = item.GetHashCode() % _size;
            return Math.Abs(position);
        }

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
