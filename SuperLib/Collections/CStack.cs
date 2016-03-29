using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLib.Collections
{
    /// <summary>
    /// A stack is a first in last out collection using an CArrayList as internal list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class CStack<T> where T : IComparable<T>
    {
        // _pIndex for keeping track of the current index;
        private int _pIndex;
        private CArrayList<T> _list;

        public CStack()
        {
            _list = new CArrayList<T>();
            // Init index on -1 so first item is 0
            _pIndex = -1;
        }

        /// <summary>
        /// Get the no of elements in the stack
        /// </summary>
        public int Count => _list.Count();

        /// <summary>
        /// Add a new item to the stack, increasing the index
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            _list.Add(item);
            _pIndex++;
        }

        /// <summary>
        /// Remove the top of the stack.
        /// Decreasing the index and returning the removed item
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            T obj = _list[_pIndex];
            _list.RemoveAt(_pIndex);
            _pIndex--;
            return obj;
        }

        /// <summary>
        /// Clearing the stack
        /// </summary>
        public void Clear()
        {
            _list.Clear();
            _pIndex = -1;
        }

        /// <summary>
        /// Just view the top of the stack
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            return _list[_pIndex];
        }
    }
}
