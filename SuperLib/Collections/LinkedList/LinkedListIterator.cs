using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLib.Collections.LinkedList
{
    /// <summary>
    /// Iterator for a LinkedList iterating over each link
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedListIterator<T>
    {
        // Inner is using the normal LinkedList
        private LinkedList<T> _innerLinkedList;
        // Always remembering the current and previous node
        private Node<T> _currentNode;
        private Node<T> _previousNode;  

        public LinkedListIterator(LinkedList<T> linkedList)
        {
            _innerLinkedList = linkedList;
            _currentNode = linkedList.First;
            _previousNode = null;
        }

        /// <summary>
        /// Go to the next node, setting the previous node
        /// </summary>
        public void NextLink()
        {
            _previousNode = _currentNode;
            _currentNode = _previousNode.Link;
        }

        /// <summary>
        /// Getter for the current node
        /// </summary>
        public T Current => _currentNode.Element;

        /// <summary>
        /// Insert before the current node
        /// </summary>
        /// <param name="element"></param>
        public void InsertBefore(T element)
        {
            Node<T> newNode = new Node<T>(element);

            newNode.Link = _currentNode;
            _currentNode = newNode;

            if (_previousNode != null)
            {
                _previousNode.Link = _currentNode;
            }
        }

        /// <summary>
        /// Insert element after the current node
        /// </summary>
        /// <param name="element"></param>
        public void InsertAfter(T element)
        {
            Node<T> newNode = new Node<T>(element);

            newNode.Link = _currentNode.Link;
            _currentNode.Link = newNode;
            NextLink();
        }

        /// <summary>
        /// Remove the current node
        /// </summary>
        public void Remove()
        {
            _previousNode.Link = _currentNode.Link;
        }

        /// <summary>
        /// Start iterating from the start again
        /// </summary>
        public void Reset()
        {
            _currentNode = _innerLinkedList.First;
            _previousNode = null;
        }

        /// <summary>
        /// Check if the end is reached
        /// </summary>
        public bool EndReached => _currentNode == null;
    }
}
