using System.Collections.Generic;

namespace SuperLib.Collections.LinkedList
{
    public class LinkedList<T>
    {
        private readonly Node<T> _header;

        public LinkedList()
        {
            _header = new Node<T>(default(T));
        }

        public void Insert(T newItem, T after)
        {
            Node<T> current = Find(after);
            Node<T> newNode = new Node<T>(newItem);

            newNode.Link = current.Link;
            current.Link = newNode;
        }

        public void InsertFirst(T newItem)
        {
            Node<T> newNode = new Node<T>(newItem);

            _header.Link = newNode;
            newNode.Link = _header;
        }

        public void Remove(T item)
        {
            Node<T> toRemove = FindPrevious(item);

            if (toRemove.Link != null)
            {
                toRemove.Link = toRemove.Link.Link;
            }
        }

        private Node<T> Find(T item)
        {
            Node<T> current = _header;

            while (!current.Element.Equals(item))
            {
                current = current.Link;
            }

            return current;
        }

        private Node<T> FindPrevious(T item)
        {
            Node<T> current = _header;

            while (current.Link != null && !current.Link.Element.Equals(item))
            {
                current = current.Link;
            }

            return current;
        }

        public Node<T> First => _header.Link;

        public IEnumerable<T> GetEnumerable()
        {
            Node<T> current = _header;

            while (!Equals(current.Link, default(T)))
            {
                current = current.Link;
                if (!Equals(current.Element, default(T))) yield return current.Element;
            }
        }
    }
}