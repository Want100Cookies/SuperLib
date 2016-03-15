using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLib.Collections.LinkedList
{
    class LinkedListIterator<T>
    {
        private LinkedList<T> _innerLinkedList;
        private Node<T> _currentNode;
        private Node<T> _previousNode;  

        public LinkedListIterator(LinkedList<T> linkedList)
        {
            _innerLinkedList = linkedList;
            _currentNode = linkedList.First;
            _previousNode = null;
        }

        public void NextLink()
        {
            _previousNode = _currentNode;
            _currentNode = _previousNode.Link;
        }

        public T Current => _currentNode.Element;

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

        public void InsertAfter(T element)
        {
            Node<T> newNode = new Node<T>(element);

            newNode.Link = _currentNode.Link;
            _currentNode.Link = newNode;
            NextLink();
        }

        public void Remove()
        {
            _previousNode.Link = _currentNode.Link;
        }

        public void Reset()
        {
            _currentNode = _innerLinkedList.First;
            _previousNode = null;
        }

        public bool EndReached => _currentNode.Link == null;
    }
}
