using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLib.Collections
{
    public class BucketHash<T> : IEnumerable<T>
    {
        private const int Size = 101;

        private CArrayList<T>[] Data;

        public BucketHash()
        {
            Data = new CArrayList<T>[Size];

            for (int i = 0; i < Size; i++)
            {
                Data[i] = new CArrayList<T>();
            }
        }

        public CArrayList<T> this[int index] => Data[index];

        public void Insert(T item)
        {
            int hash = item.GetHashCode();
            Data[hash].Add(item);
        }

        public void Remove(T item)
        {
            int hash = item.GetHashCode();
            if (Data[hash].Contains(item))
            {
                Data[hash].Remove(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Size; i++)
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
