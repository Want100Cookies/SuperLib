using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLib.Collections
{
    public class CPriorityQueue<T> where T : IComparable<T>
    {
        private CArrayList<CQueue<T>> _queue;

        public CPriorityQueue()
        {
            _queue = new CArrayList<CQueue<T>>();
        }

        public void EnQueue(T item, int priority)
        {
            if (_queue[priority].Equals(null))
            {
                _queue[priority] = new CQueue<T>();
            }

            _queue[priority].EnQueue(item);
        }

        public void DeQueue()
        {
            if (!_queue.Any())
            {
                return;
            }

            if (Peek().Equals(null))
            {
                _queue.RemoveAt(_queue.IndexOf(_queue.First()));
                
                DeQueue();
            }
            else
            {
                _queue.First().DeQueue();
            }
        }

        public object Peek()
        {
            return _queue.First().Peek();
        }

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
