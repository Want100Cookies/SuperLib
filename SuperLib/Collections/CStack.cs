using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLib.Collections
{
    class CStack<T> where T : IComparable<T>
    {
        private int _pIndex;
        private CArrayList<T> _list;

        public CStack()
        {
            _list = new CArrayList<T>();
            _pIndex = -1;
        }

        public int Count => _list.Count();

        public void Push(T item)
        {
            _list.Add(item);
            _pIndex++;
        }

        public T Pop()
        {
            T obj = _list[_pIndex];
            _list.RemoveAt(_pIndex);
            _pIndex--;
            return obj;
        }

        public void Clear()
        {
            _list.Clear();
            _pIndex = -1;
        }

        public T Peek()
        {
            return _list[_pIndex];
        }
    }
}
