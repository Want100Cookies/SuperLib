using System;
using System.Collections;
using System.Collections.Generic;

namespace SuperLib.Collections.Hash
{
    public class BucketHash<T> : IEnumerable<T>
    {
        private readonly int _size;

        private CArrayList<T>[] Data;

        public BucketHash(int size)
        {
            _size = size;
            Data = new CArrayList<T>[_size];

            for (int i = 0; i < _size; i++)
            {
                Data[i] = new CArrayList<T>();
            }
        }

        public void Insert(T item)
        {
            int position = GetPosition(item);
            Data[position].Add(item);
        }

        public void Remove(T item)
        {
            int position = GetPosition(item);
            if (Data[position].Contains(item))
            {
                Data[position].Remove(item);
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
                foreach (T item in Data[i])
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
