using System;
using System.Collections;
using System.Collections.Generic;

namespace SuperLib.Collections.Hash
{
    public class BucketHash<T> : IEnumerable<T>
    {
        private readonly int _size;

        private CArrayList<T>[] _data;

        public BucketHash(int size)
        {
            _size = size;
            _data = new CArrayList<T>[_size];

            for (int i = 0; i < _size; i++)
            {
                _data[i] = new CArrayList<T>();
            }
        }

        public void Insert(T item)
        {
            int position = GetPosition(item);
            _data[position].Add(item);
        }

        public void Remove(T item)
        {
            int position = GetPosition(item);
            if (_data[position].Contains(item))
            {
                _data[position].Remove(item);
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
