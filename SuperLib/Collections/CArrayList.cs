using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLib.Collections
{
    /// <summary>
    /// Custom ArrayList with almost the same functions as the original one.
    /// Using a array as an innerlist
    /// </summary>
    /// <typeparam name="T"></typeparam>
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

        /// <summary>
        /// Faster insetion at the end cause nothing has to be moved
        /// </summary>
        /// <param name="item"></param>
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

        /// <summary>
        /// Remove item at the given index
        /// </summary>
        /// <param name="index"></param>
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

        /// <summary>
        /// Remove given item
        /// </summary>
        /// <param name="item"></param>
        public void Remove(T item)
        {
            RemoveAt(IndexOf(item));
        }

        /// <summary>
        /// Remove items between start and stop
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
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

        /// <summary>
        /// Alias for this[index] = item
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        public void Insert(int index, T item)
        {
            this[index] = item;
        }

        /// <summary>
        /// Insert an array of items at index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="items"></param>
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

        /// <summary>
        /// Get a range of items in the form of a CArrayList
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        /// <returns></returns>
        public CArrayList<T> GetRange(int start, int stop)
        {
            T[] returnList = new T[stop - start];

            for (int i = start; i < stop; i++)
            {
                returnList[i - start] = _innerList[i];
            }

            return new CArrayList<T>(returnList);
        }

        /// <summary>
        /// Get the index of an item starting at the given index
        /// </summary>
        /// <param name="item"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public int IndexOf(T item, int start)
        {
            for (int i = start; i < _count; i++)
            {
                if (!_innerList[i].Equals(item)) continue;

                return i;
            }

            return -1;
        }

        /// <summary>
        /// Alias for IndexOf(item, 0)
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int IndexOf(T item)
        {
            return IndexOf(item, 0);
        }

        /// <summary>
        /// Reverse for IndexOf(item)
        /// </summary>
        /// <param name="item"></param>
        /// <param name="stop"></param>
        /// <returns></returns>
        public int LastIndexOf(T item, int stop)
        {
            for (int i = stop; i >= 0; i--)
            {
                if (!_innerList[i].Equals(item)) continue;

                return i;
            }

            return -1;
        }

        /// <summary>
        /// Alias for LastIndexOf(item, 0)
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int LastIndexOf(T item)
        {
            return LastIndexOf(item, _count);
        }

        /// <summary>
        /// Reverse the collection
        /// </summary>
        public void Reverse()
        {
            // Only need to reverse half the collection
            for (int i = 0; i < _count / 2; i++)
            {
                T tmp = _innerList[i];
                _innerList[i] = _innerList[_count - i - 1]; // Example i = 3, size = 10 then 10-3-1 = 6 EXACT OPPOSITE
                _innerList[_count - i - 1] = tmp; // so swap
            }
        }

        /// <summary>
        /// Check if the collection contains item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Clear the whole collection
        /// </summary>
        public void Clear()
        {
            _count = 0;
            _innerList = new T[_count];
        }

        /// <summary>
        /// Shallow copy of this
        /// </summary>
        /// <returns></returns>
        public CArrayList<T> Copy()
        {
            return this;
        }

        /// <summary>
        /// Create new clone of _innerList
        /// </summary>
        /// <returns></returns>
        public CArrayList<T> Clone()
        {
            return new CArrayList<T>(_innerList);
        }

        /// <summary>
        /// Enumerate on every item
        /// </summary>
        /// <returns></returns>
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
