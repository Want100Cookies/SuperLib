using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLib.Collections
{
    public class CArrayList<T> : IEnumerable<T>
    {
        private T[] _innerList;
        private int _count;

        public CArrayList()
        {
            _count = 0;
            _innerList = new T[_count];
        }

        public CArrayList(int size)
        {
            _count = size;
            _innerList = new T[_count];
        }

        public CArrayList(T[] array)
        {
            _count = 0;
            _innerList = new T[_count];

            for (int i = 0; i < array.Length; i++)
            {
                this[i] = array[i];
            }
        }
        
        public T this[int index]
        {
            get { return _innerList[index]; } // Simple getter
            set
            {
                if (index < (_count - 1)) // If in current bounds of array, no modification needed
                {
                    _innerList[index] = value;
                }
                else // Or else, I cry
                {
                    T[] newInnerList = new T[_count + 1]; // Start a new array with +1 length
                    bool move = false;
                    for (int i = 0; i < _count; i++) // For each old entry in the array
                    {
                        if (i == index) // If index is the same as the new value
                        {
                            newInnerList[i] = value; // Set new value in the current place
                            move = true; // Every following entry has to move 1 place forward
                        }
                        
                        if (move) // If item has to be moved
                        {
                            newInnerList[i + 1] = _innerList[i]; // Set to old place + 1
                        }
                        else // Else
                        {
                            newInnerList[i] = _innerList[i]; // Simply copy
                        }
                    }

                    _count++;
                    _innerList = newInnerList;
                }
            }
        }

        public void Add(T item)
        {
            T[] newInnerList = new T[_count + 1];

            for (int i = 0; i < _count; i++)
            {
                newInnerList[i] = _innerList[i];
            }

            _count++;
            newInnerList[_count-1] = item;

            _innerList = newInnerList;
        }

        public void RemoveAt(int index)
        {
            T[] newInnerList = new T[_count - 1];

            for (int i = 0; i < (_count-1); i++) // For each old entry in the array (minus one ofcourse)
            {
                if (i >= index) // If index is the same or higher as the to be deleted value
                {
                    newInnerList[i] = _innerList[i + 1]; // Set new value in the current place (thus deleting the one and index)
                }
                else // Else
                {
                    newInnerList[i] = _innerList[i]; // Simply copy
                }
            }

            _count--;
            _innerList = newInnerList;
        }

        public void Remove(T item)
        {
            RemoveAt(IndexOf(item));
        }

        public void RemoveRange(int start, int stop)
        {
            T[] newInnerList = new T[_count - (stop - start)];
            int j = 0;

            for (int i = 0; i < _count; i++)
            {
                if (i >= start && i <= stop) continue; // If the current index is not between start and stop, just copy to newInnerList

                newInnerList[j] = _innerList[i];
                j++;
            }

            _count -= stop - start;
            _innerList = newInnerList;
        }

        public void Insert(int index, T item)
        {
            this[index] = item;
        }

        public void InsertRange(int index, T[] items)
        {
            T[] newInnerList = new T[_count + items.Length]; // Start a new array with +1 length

            bool move = false;

            for (int i = 0; i < _count; i++) // For each old entry in the array
            {
                if (i == index) // If index is the same as the new value
                {
                    for (int j = 0; j < items.Length; j++) // Add all new items
                    {
                        newInnerList[i + j] = items[j];
                    }

                    move = true; // Every following entry has to move items.length places forward
                }

                if (move) // If item has to be moved
                {
                    newInnerList[i + items.Length] = _innerList[i]; // Set to old place + items.length
                }
                else // Else
                {
                    newInnerList[i] = _innerList[i]; // Simply copy
                }
            }

            _count += items.Length;
            _innerList = newInnerList;
        }

        public CArrayList<T> GetRange(int start, int stop)
        {
            T[] returnList = new T[stop - start];

            for (int i = start; i < stop; i++)
            {
                returnList[i - start] = _innerList[i];
            }

            return new CArrayList<T>(returnList);
        }

        public int IndexOf(T item, int start)
        {
            for (int i = start; i < _count; i++)
            {
                if (!_innerList[i].Equals(item)) continue;

                return i;
            }

            return -1;
        }

        public int IndexOf(T item)
        {
            return IndexOf(item, 0);
        }

        public int LastIndexOf(T item, int stop)
        {
            for (int i = stop; i >= 0; i--)
            {
                if (!_innerList[i].Equals(item)) continue;

                return i;
            }

            return -1;
        }

        public int LastIndexOf(T item)
        {
            return LastIndexOf(item, _count);
        }

        public void Reverse()
        {
            for (int i = 0; i < _count / 2; i++)
            {
                T tmp = _innerList[i];
                _innerList[i] = _innerList[_count - i - 1];
                _innerList[_count - i - 1] = tmp;
            }
        }

        public bool Contains(T item)
        {
            bool inArray = false;

            for (int i = 0; i < _count; i++)
            {
                if (!_innerList[i].Equals(item)) continue;

                inArray = true;
                break;
            }

            return inArray;
        }

        public int Count()
        {
            return _count;
        }

        public void Clear()
        {
            _count = 0;
            _innerList = new T[_count];
        }

        public CArrayList<T> Copy()
        {
            return this;
        }

        public CArrayList<T> Clone()
        {
            return new CArrayList<T>(_innerList);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _innerList[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
