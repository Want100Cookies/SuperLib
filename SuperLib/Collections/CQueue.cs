using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLib.Collections
{
    /// <summary>
    /// A queue is a first in first out collection using a CArrayList as internal list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CQueue<T> where T : IComparable<T>
    {
        private CArrayList<T> _queue;

        public CQueue()
        {
            _queue = new CArrayList<T>();
        }

        /// <summary>
        /// Adds a new item to the queue at the top
        /// </summary>
        /// <param name="item"></param>
        public void EnQueue(T item)
        {
            _queue.Add(item);
        }

        /// <summary>
        /// Removes the first item in the queue (also returning it)
        /// </summary>
        public T DeQueue()
        {
            T tmp = Peek();
            _queue.RemoveAt(0);
            return tmp;
        }

        /// <summary>
        /// View the first item in the queue without deleting it
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            return _queue[0];
        }

        /// <summary>
        /// Empty the whole queue
        /// </summary>
        public void ClearQueue()
        {
            _queue.Clear();
        }

        /// <summary>
        /// Get the no of item in the queue
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return _queue.Count();
        }
    }
}
