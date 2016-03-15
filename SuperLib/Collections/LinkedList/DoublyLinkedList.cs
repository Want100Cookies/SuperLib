using System.Collections.Generic;

namespace SuperLib.Collections.LinkedList
{
    public class DoublyLinkedList<T>
    {
        private readonly DoublyNode<T> _header; 
        
        public DoublyLinkedList()
        {
            _header = new DoublyNode<T>(default(T));
        }

        public void Insert(T newItem, T after)
        {
            DoublyNode<T> current = Find(after);
            DoublyNode<T> newNode = new DoublyNode<T>(newItem);

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
            DoublyNode<T> newNode = new DoublyNode<T>(newItem);

            newNode.After = _header.After;
            newNode.Before = _header;
            _header.After = newNode;
        }

        public void Remove(T item)
        {
            DoublyNode<T> toRemove = Find(item);

            if (!Equals(toRemove.After, default(T)))
            {
                toRemove.Before.After = toRemove.After;
                toRemove.After.Before = toRemove.Before;
            }
            else
            {
                toRemove.Before.After = new DoublyNode<T>(default(T));
            }
        }

        private DoublyNode<T> Find(T item)
        {
            DoublyNode<T> current = _header;

            while (!current.Element.Equals(item))
            {
                current = current.After;
            }

            return current;
        }

        private DoublyNode<T> FindLast()
        {
            DoublyNode<T> current = _header;

            while (current.After != null)
            {
                current = current.After;
            }

            return current;
        } 

        public IEnumerable<T> GetEnumerable()
        {
            DoublyNode<T> current = _header;

            while (current.After != null)
            {
                current = current.After;
                yield return current.Element;
            }
        }

        public IEnumerable<T> GetReverseEnumerable()
        {
            DoublyNode<T> current = FindLast();

            while (current.Before != null)
            {
                current = current.Before;
                yield return current.After.Element;
            }
        }
    }
}
