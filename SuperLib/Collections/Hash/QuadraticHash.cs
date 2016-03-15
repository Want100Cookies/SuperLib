using System;
using System.Collections;
using System.Collections.Generic;

namespace SuperLib.Collections.Hash
{
    public class QuadraticHash<T> : IEnumerable<T>
    {
        private readonly int _size;

        private T[] Data;

        public QuadraticHash(int size)
        {
            _size = size;
            Data = new T[_size];
        }

        public void Insert(T item)
        {
            int position = GetPosition(item);

            bool finished = false;
            int index = position;
            int tries = 0;
            bool startedFromBeginning = false;

            while (!finished)
            {
                if (Equals(Data[index], default(T))) // Empty element
                {
                    Data[index] = item;
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

        public void Remove(T item)
        {
            int position = GetPosition(item);

            bool finished = false;
            int index = position;
            int tries = 0;
            bool startedFromBeginning = false;

            while (!finished)
            {
                if (Data[index].Equals(item)) // Empty element
                {
                    Data[index] = default(T);
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

        protected int GetPosition(T item)
        {
            int position = item.GetHashCode() % _size;
            return Math.Abs(position);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _size; i++)
            {
                if (!Equals(Data[i], default(T))) yield return Data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
