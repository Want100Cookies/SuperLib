using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLib.Collections
{
    /// <summary>
    /// A collection using the binary search tree algorithm (see book for more information
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        // Root node containing all the other nodes
        private Node<T> _rootNode;

        // Node implementation
        public class Node<T>
        {
            public T Data { get; set; }
            public Node<T> Left { get; set; }
            public Node<T> Right { get; set; }

            public Node(T data)
            {
                this.Data = data;
            } 
        }

        public Node<T> RootNode
        {
            get { return _rootNode; }
            private set { _rootNode = value; }
        }

        /// <summary>
        /// Constructor setting RootNode to null
        /// </summary>
        public BinarySearchTree()
        {
            RootNode = null;
        }

        /// <summary>
        /// Insert the given element under the given rootNode
        /// </summary>
        /// <param name="element"></param>
        /// <param name="rootNode"></param>
        public void Insert(T element, ref Node<T> rootNode)
        {
            // For an empty rootNode, create one
            if (rootNode == null)
            {
                rootNode = new Node<T>(element);
            }
            else
            {
                // Else create just a new node
                Node<T> newNode = new Node<T>(element);

                Node<T> currentNode = rootNode;

                // End loop til node is place in the tree
                while (true)
                {
                    Node<T> parentNode = currentNode;

                    // Compare new node to current
                    if (newNode.Data.CompareTo(currentNode.Data) < 0)
                    {
                        // newNode is smaller so to the left leg
                        currentNode = currentNode.Left;
                        if (currentNode != null) continue; // Not null? next round more luck

                        // Null, yesss. Set the new node and stop the infinite loop
                        parentNode.Left = newNode;
                        break;
                    }
                    else
                    {
                        // Same as first part of the if but then for right/bigger
                        currentNode = currentNode.Right;
                        if (currentNode != null) continue;

                        parentNode.Right = newNode;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Insert at the top (root)
        /// </summary>
        /// <param name="element"></param>
        public void Insert(T element)
        {
            Insert(element, ref _rootNode);
        }

        /// <summary>
        /// Delete the given value from the tree (first occurence)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Delete(T value)
        {
            Node<T> current = RootNode;
            Node<T> parent = RootNode;

            bool isLeftChild = true;

            // Find the given node (and it's parent)
            while (current.Data.CompareTo(value) != 0)
            {
                parent = current;
                if (value.CompareTo(current.Data) < 0)
                {
                    isLeftChild = true;
                    current = current.Left;
                }
                else
                {
                    isLeftChild = false;
                    current = current.Right;
                }

                if (current == null)
                {
                    return false;
                }
            }
            
            // Init new/old tree vars
            Node<T> newTree = null;
            Node<T> oldTree;

            // Set the old tree to left or right
            if (isLeftChild)
            {
                oldTree = parent.Left;
            }
            else
            {
                oldTree = parent.Right;
            }

            // For each item under the old tree, add it to the new tree
            foreach (T newValue in EnumerableInOrder(oldTree))
            {
                if (newValue.Equals(value)) // Except the value to be deleted
                {
                    continue;
                }

                Insert(newValue, ref newTree);
            }

            // Set the new tree under the left/right leg
            if (isLeftChild)
            {
                parent.Left = newTree;
            }
            else
            {
                parent.Right = newTree;
            }

            return true;
        }

        /// <summary>
        /// Traverse the tree to get the minimum (most left leg)
        /// </summary>
        public T Min
        {
            get
            {
                Node<T> current = RootNode;
                while (current.Left != null)
                {
                    current = current.Left;
                }
                return current.Data;
            }
        }

        /// <summary>
        /// Traverse the tree to get the maximum (most right leg)
        /// </summary>
        public T Max
        {
            get
            {
                Node<T> current = RootNode;
                while (current.Right != null)
                {
                    current = current.Right;
                }
                return current.Data;
            }
        }

        /// <summary>
        /// Find the given value in the tree
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node<T> FindNode(T value)
        {
            Node<T> current = RootNode;

            // While not found
            while (current.Data.CompareTo(value) != 0)
            {
                if (value.CompareTo(current.Data) < 0)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }

                if (current == null) return null;
            }

            return current;
        } 

        /// <summary>
        /// Get every node from left to right (small to big)
        /// </summary>
        /// <param name="rootNode"></param>
        /// <returns></returns>
        public IEnumerable<T> EnumerableInOrder(Node<T> rootNode)
        {
            if (rootNode == null) yield break;

            foreach (T leftElement in EnumerableInOrder(rootNode.Left))
            {
                yield return leftElement;
            }

            yield return rootNode.Data;

            foreach (T rightElement in EnumerableInOrder(rootNode.Right))
            {
                yield return rightElement;
            }
        }

        /// <summary>
        /// Get every node in hiearchie (starting from the top, traversing down every level)
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public IEnumerable<T> EnumerablePreOrder(Node<T> node)
        {
            if (node == null) yield break;

            yield return node.Data;

            foreach (T leftElement in EnumerablePreOrder(node.Left))
            {
                yield return leftElement;
            }

            foreach (T rightElement in EnumerablePreOrder(node.Right))
            {
                yield return rightElement;
            }
        }

        /// <summary>
        /// Inverse of PreOrder, traversing from the bottom to the top
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public IEnumerable<T> EnumerablePostOrder(Node<T> node)
        {
            if (node == null) yield break;

            foreach (T leftElement in EnumerablePreOrder(node.Left))
            {
                yield return leftElement;
            }

            foreach (T rightElement in EnumerablePreOrder(node.Right))
            {
                yield return rightElement;
            }

            yield return node.Data;
        } 
    }
}
