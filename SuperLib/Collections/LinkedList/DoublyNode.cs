namespace SuperLib.Collections.LinkedList
{
    /// <summary>
    /// A node with a link to the node before and after this node
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DoublyNode<T>
    {
        public T Element { get; }

        public DoublyNode<T> Before { get; set; }
        public DoublyNode<T> After { get; set; }

        public DoublyNode(T element)
        {
            Element = element;
            Before = null;
            After = null;
        }
    }
}
