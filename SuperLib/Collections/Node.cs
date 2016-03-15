using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLib.Collections
{
    public class Node<T>
    {
        public T Element { get; }

        public Node<T> Link { get; set; }

        public Node(T element)
        {
            Element = element;
            Link = null;
        }
    }
}
