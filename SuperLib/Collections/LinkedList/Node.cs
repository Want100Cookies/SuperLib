namespace SuperLib.Collections.LinkedList
{
    /// <summary>
    /// Simple node for linked lists
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        public T Element { get; }

        public Node<T> Link { get; set; }

        public Node(T element)
        {
            Element = element;
            Link = null;
        }
    }
}
