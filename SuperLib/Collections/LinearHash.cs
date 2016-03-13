using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperLib.Collections
{
    public class LinearHash<T> : IEnumerable<T>
    {
        private readonly int _size ;

        private T[] Data;

        public LinearHash(int size)
        {
            _size = size;
            Data = new T[_size];
        }

        public void Insert(T item)
        {
            int position = GetPosition(item);

            bool finished = false;
            int index = position;
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
                    index++;
                    if (index >= _size - 1) // If index is out of bound
                    {
                        if (startedFromBeginning) throw new IndexOutOfRangeException("There is not enough room"); // Only if we allready started from the beginning
                        index = 0;
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
                    index++;
                    if (index >= _size - 1) // If index is out of bound
                    {
                        if (startedFromBeginning) throw new IndexOutOfRangeException("There is not enough room"); // Only if we allready started from the beginning
                        index = 0;
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
