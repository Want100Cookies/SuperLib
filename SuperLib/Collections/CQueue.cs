using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLib.Collections
{
    public class CQueue<T> where T : IComparable<T>
    {
        private CArrayList<T> _queue;

        public CQueue()
        {
            _queue = new CArrayList<T>();
        }

        public void EnQueue(T item)
        {
            _queue.Add(item);
        }

        public void DeQueue()
        {
            _queue.RemoveAt(0);
        }

        public T Peek()
        {
            return _queue[0];
        }

        public void ClearQueue()
        {
            _queue.Clear();
        }

        public int Count()
        {
            return _queue.Count();
        }
    }
}
