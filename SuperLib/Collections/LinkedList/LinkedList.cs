using System.Collections.Generic;

namespace SuperLib.Collections.LinkedList
{
    /// <summary>
    /// Simple linked list implementation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T>
    {
        /// <summary>
        /// Header of the list (first node)
        /// </summary>
        private readonly Node<T> _header;

        public LinkedList()
        {
            _header = new Node<T>(default(T));
        }

        /// <summary>
        /// Insert a new item after the given value
        /// </summary>
        /// <param name="newItem"></param>
        /// <param name="after"></param>
        public void Insert(T newItem, T after)
        {
            Node<T> current = Find(after);
            Node<T> newNode = new Node<T>(newItem);

            newNode.Link = current.Link;
            current.Link = newNode;
        }

        /// <summary>
        /// Insert the first node
        /// </summary>
        /// <param name="newItem"></param>
        public void InsertFirst(T newItem)
        {
            Node<T> newNode = new Node<T>(newItem);

            _header.Link = newNode;
            //newNode.Link = _header;
        }

        /// <summary>
        /// Remove the node with the given value
        /// </summary>
        /// <param name="item"></param>
        public void Remove(T item)
        {
            Node<T> toRemove = FindPrevious(item);

            if (toRemove.Link != null)
            {
                toRemove.Link = toRemove.Link.Link;
            }
        }

        /// <summary>
        /// Find the node for the given value
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private Node<T> Find(T item)
        {
            Node<T> current = _header;

            while (!current.Element.Equals(item))
            {
                current = current.Link;
            }

            return current;
        }

        /// <summary>
        /// Find the node before the given value
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
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
        /// Get the first item
        /// </summary>
        public Node<T> First => _header.Link;

        /// <summary>
        /// Enumerate over all values (wihtout the defaults)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetEnumerable()
        {
            Node<T> current = _header;

            while (current != null)
            {
                current = current.Link;
                if (current != null) yield return current.Element;
            }
        }
    }
}