using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLib.Collections
{
    public class CArray<T> : IEnumerable<T> where T : IComparable<T>
    {
        protected T[] _arr;
        private readonly int _upper;
        private int _numElements;

        public CArray(int size)
        {
            _arr = new T[size];
            _upper = size - 1;
            _numElements = 0;
        }

        public T[] GetArray()
        {
            return _arr;
        }

        public T this[int index]
        {
            get { return _arr[index]; }
            set
            {
                if (index < _upper)
                {
                    _arr[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index " + index + " does not exist!");
                }
            }
        }

        public void Insert(T item)
        {
            _arr[_numElements] = item;
            _numElements++;
        }

        public void DisplayElements()
        {
            for (int i = 0; i < _upper; i++)
            {
                Console.Write(_arr[i] + " ");
            }

            Console.WriteLine();
        }

        public void Clear()
        {
            for (int i = 0; i < _upper; i++)
            {
                _arr[i] = default(T);
            }
            _numElements = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _upper; i++)
            {
                yield return _arr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int NumElements => _numElements;
        public int Upper => _upper;
    }
}
