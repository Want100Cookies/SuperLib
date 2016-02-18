using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SuperLib.Collections
{
    public class SuperCollection<T> : ICollection<T>
    {
        private T[] _collection;

        int ICollection<T>.Count => _collection.Length;

        public bool IsReadOnly => ((ICollection<T>)_collection).IsReadOnly;

        public SuperCollection()
        {
            _collection = new T[0];
        }

        public void Add(T item)
        {
            Array.Resize(ref _collection, _collection.Count() + 1);

            _collection[_collection.Count() - 1] = item;
        }

        public void Remove(T item)
        {
            _collection[Array.IndexOf(_collection, item)] = _collection[_collection.Count() - 1];

            Array.Resize(ref _collection, _collection.Count() - 1);
        }

        public bool Contains(T item)
        {
            return _collection.Contains(item);
        }

        public T GetItem(int index)
        {
            return _collection[index];
        }

        public int Count()
        {
            return _collection.Length;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _collection.Cast<T>().GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _collection.Cast<T>().GetEnumerator();
        }

        public void Clear()
        {
            ((ICollection<T>)_collection).Clear();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ((ICollection<T>)_collection).CopyTo(array, arrayIndex);
        }

        bool ICollection<T>.Remove(T item)
        {
            return ((ICollection<T>)_collection).Remove(item);
        }
    }
}