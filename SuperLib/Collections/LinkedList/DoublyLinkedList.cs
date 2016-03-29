using System.Collections.Generic;

namespace SuperLib.Collections.LinkedList
{
    /// <summary>
    /// A linked list where every node links to the node before aswell the node after it
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DoublyLinkedList<T>
    {
        /// <summary>
        /// Header node, linking to the first and last node
        /// </summary>
        private readonly DoublyNode<T> _header; 
        
        public DoublyLinkedList()
        {
            _header = new DoublyNode<T>(default(T));
        }

        /// <summary>
        /// Insert a new node after the given value
        /// </summary>
        /// <param name="newItem"></param>
        /// <param name="after"></param>
        public void Insert(T newItem, T after)
        {
            DoublyNode<T> current = Find(after);
            DoublyNode<T> newNode = new DoublyNode<T>(newItem);

            newNode.Before = current;
            newNode.After = current.After;

            current.After = newNode;

            // If there is a node after current
            if (!Equals(newNode.After, null))
            {
                // The node after newNode has to link to newNode (before attribute)
                newNode.After.Before = newNode;
            }
        }

        /// <summary>
        /// Set the first node
        /// </summary>
        /// <param name="newItem"></param>
        public void InsertFirst(T newItem)
        {
            DoublyNode<T> newNode = new DoublyNode<T>(newItem);

            newNode.After = _header.After;
            newNode.Before = _header;
            _header.After = newNode;
        }

        /// <summary>
        /// Remove the given value
        /// </summary>
        /// <param name="item"></param>
        public void Remove(T item)
        {
            DoublyNode<T> toRemove = Find(item);

            if (!Equals(toRemove.After, default(T)))
            {
                // Set the before and after so that they don't refferece toRemove anymore
                toRemove.Before.After = toRemove.After;
                toRemove.After.Before = toRemove.Before;
            }
            else
            {
                // Set to default
                toRemove.Before.After = new DoublyNode<T>(default(T));
            }
        }

        /// <summary>
        /// Find the given value
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private DoublyNode<T> Find(T item)
        {
            DoublyNode<T> current = _header;

            while (!current.Element.Equals(item))
            {
                current = current.After;
            }

            return current;
        }

        /// <summary>
        /// Find the last node in the list
        /// </summary>
        /// <returns></returns>
        private DoublyNode<T> FindLast()
        {
            DoublyNode<T> current = _header;

            while (current.After != null)
            {
                current = current.After;
            }

            return current;
        } 

        /// <summary>
        /// Get all the values in order
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetEnumerable()
        {
            DoublyNode<T> current = _header;

            while (current.After != null)
            {
                current = current.After;
                yield return current.Element;
            }
        }

        /// <summary>
        /// Get all values in reverse order
        /// </summary>
        /// <returns></returns>
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
