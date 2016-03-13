using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLib.Collections
{
    public class DoublyLinkedList<T>
    {
        private readonly Node<T> _header; 
        
        public DoublyLinkedList()
        {
            _header = new Node<T>(default(T));
        }

        public void Insert(T newItem, T after)
        {
            Node<T> current = Find(after);
            Node<T> newNode = new Node<T>(newItem);

            newNode.Before = current;
            newNode.After = current.After;

            current.After = newNode;

            if (!Equals(newNode.After, null))
            {
                newNode.After.Before = newNode;
            }
        }

        public void InsertFirst(T newItem)
        {
            Node<T> newNode = new Node<T>(newItem);

            newNode.After = _header.After;
            newNode.Before = _header;
            _header.After = newNode;
        }

        public void Remove(T item)
        {
            Node<T> toRemove = Find(item);

            if (!Equals(toRemove.After, default(T)))
            {
                toRemove.Before.After = toRemove.After;
                toRemove.After.Before = toRemove.Before;
            }
            else
            {
                toRemove.Before.After = new Node<T>(default(T));
            }
        }

        private Node<T> Find(T item)
        {
            Node<T> current = _header;

            while (!current.Element.Equals(item))
            {
                current = current.After;
            }

            return current;
        }

        private Node<T> FindLast()
        {
            Node<T> current = _header;

            while (current.After != null)
            {
                current = current.After;
            }

            return current;
        } 

        public IEnumerable<T> GetEnumerable()
        {
            Node<T> current = _header;

            while (current.After != null)
            {
                current = current.After;
                yield return current.Element;
            }
        }

        public IEnumerable<T> GetReverseEnumerable()
        {
            Node<T> current = FindLast();

            while (current.Before != null)
            {
                current = current.Before;
                yield return current.After.Element;
            }
        }

        public class Node<T>
        {
            public T Element { get; }

            public Node<T> Before { get; set; }
            public Node<T> After { get; set; }

            public Node(T element)
            {
                Element = element;
                Before = null;
                After = null;
            } 
        }
    }
}
