using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLib.Collections
{
    public class DoublyNode<T>
    {
        public T Element { get; }

        public DoublyNode<T> Before { get; set; }
        public DoublyNode<T> After { get; set; }

        public DoublyNode(T element)
        {
            Element = element;
            Before = null;
            After = null;
        }
    }
}
