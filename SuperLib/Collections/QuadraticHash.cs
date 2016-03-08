using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLib.Collections
{
    public class QuadraticHash<T> : IEnumerable<T>
    {
        private const int Size = 101;

        private T[] Data;

        public QuadraticHash()
        {
            Data = new T[Size];
        }

        public T this[int index] => Data[index];

        public void Insert(T item)
        {
            int hash = item.GetHashCode();

            if (Data[hash].Equals(default(T)))
            {
                Data[hash] = item;
            }
            else
            {
                int tries = 1;
                bool saved = false;

                while (!saved)
                {
                    if (!Data[hash + tries].Equals(default(T)))
                    {
                        tries++;
                    }
                    else
                    {
                        Data[hash + tries] = item;
                        saved = true;
                    }
                }
            }
        }

        public void Remove(T item)
        {
            int hash = item.GetHashCode();

            if (Data[hash].Equals(item))
            {
                Data[hash] = default(T);
            }
            else
            {
                int tries = 1;
                bool saved = false;

                while (!saved)
                {
                    if (!Data[hash + tries].Equals(item))
                    {
                        tries++;
                    }
                    else
                    {
                        Data[hash + tries] = default(T);
                        saved = true;
                    }
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in Data)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}