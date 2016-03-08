﻿using System;
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
        private const int Size = 101;

        private T[] Data;

        public LinearHash()
        {
            Data = new T[Size];
        }

        public T this[int index] => Data[index];

        public void Insert(T item)
        {
            int hash = item.GetHashCode();

            bool finished = false;
            int index = hash;
            bool startedFromBeginning = false;

            while (!finished)
            {
                if (Data[index].Equals(default(T))) // Empty element
                {
                    Data[index] = item;
                    finished = true;
                }
                else
                {
                    index++;
                    if (index >= Size - 1) // If index is out of bound
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
            int hash = item.GetHashCode();

            if (Data[hash].Equals(item))
            {
                Data = Data.Except(new[] {Data[hash]}).ToArray();
            }
            else
            {
                int tries = 1;
                bool deleted = false;

                while (!deleted)
                {
                    if (!Data[hash + tries].Equals(item))
                    {
                        tries++;
                    }
                    else
                    {
                        Data = Data.Except(new[] {Data[hash + tries]}).ToArray();
                        deleted = true;
                    }
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Size; i++)
            {
                if (!Data[i].Equals(default(T))) yield return Data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
