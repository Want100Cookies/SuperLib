using System.Collections.Generic;

namespace SuperLib.Collections.LinkedList
{
    /// <summary>
    /// The same as a normal linked list but the last node is linking to the header instead of null
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CircularLinkedList<T>
    {
        private readonly Node<T> _header;

        public CircularLinkedList()
        {
            _header = new Node<T>(default(T));
            // Link to the header
            _header.Link = _header;
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

        /// <summary>
        /// Get all values for x number of iterations (or else it would be infinite)
        /// </summary>
        /// <param name="iterations"></param>
        /// <returns></returns>
        public IEnumerable<T> GetEnumerable(int iterations)
        {
            Node<T> current = _header;
            int i = 0;

            while (i < iterations)
            {
                if (current.Link.Equals(_header))
                {
                    i++;
                }

                current = current.Link;
                if (!Equals(current.Element, default(T))) yield return current.Element;
            }
        }
    }
}
