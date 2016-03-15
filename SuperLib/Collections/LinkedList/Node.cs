namespace SuperLib.Collections.LinkedList
{
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
