using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLib.Collections
{
    /// <summary>
    /// Same as queue but than with priority built in
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CPriorityQueue<T> where T : IComparable<T>
    {
        // Every priority has a own Queue wich contains all the items with the given priority
        private CArrayList<CQueue<T>> _queue;

        public CPriorityQueue()
        {
            _queue = new CArrayList<CQueue<T>>();
        }

        /// <summary>
        /// Add a new item with the given priority to the queue.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="priority"></param>
        public void EnQueue(T item, int priority)
        {
            // Check if this priority allready exists
            if (_queue[priority].Equals(null))
            {
                _queue[priority] = new CQueue<T>();
            }

            // Add the item to the given priority queue
            _queue[priority].EnQueue(item);
        }

        /// <summary>
        /// Remove the first item in the queue with the lowest priority
        /// </summary>
        public T DeQueue()
        {
            // If the queue is empty, do nothing
            if (!_queue.Any())
            {
                return default(T);
            }

            // If the first Queue contains nothing
            if (Peek().Equals(null))
            {
                // Remove it
                _queue.RemoveAt(_queue.IndexOf(_queue.First()));
                // Continue to the next queue (cause nothing is deQueue'ed yet)
                return DeQueue();
            }

            // DeQueue the first item in the queue
            return _queue.First().DeQueue();
        }

        /// <summary>
        /// Peek in the lowes priority queue
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if (!_queue.Any())
            {
                return default(T);
            }

            // Get the first peek
            T tmp = _queue.First().Peek();

            // If the first Queue contains nothing
            if (tmp.Equals(null))
            {
                // Remove it
                _queue.RemoveAt(_queue.IndexOf(_queue.First()));
                // Continue to the next queue (cause nothing is peek'ed yet)
                return Peek();
            }

            // Return the tmp for peeking 
            return tmp;
        }

        /// <summary>
        /// Clear all priorities
        /// </summary>
        public void ClearQueue()
        {
            _queue.Clear();
        }

        public int Count()
        {
            return _queue.Sum(queue => queue.Count());
        }
    }
}
