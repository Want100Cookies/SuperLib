using System.Collections;

namespace SuperLib.Collections
{
    public class Collection : CollectionBase
    {
        public void Add(object item)
        {
            InnerList.Add(item);
        }

        public void Insert(int index, object item)
        {
            InnerList.Insert(index, item);
        }

        public int IndexOf(object item)
        {
            return InnerList.IndexOf(item);
        }

        public void Remove(object item)
        {
            InnerList.Remove(item);
        }

        public new void RemoveAt(int index)
        {
            InnerList.RemoveAt(index);
        }

        public bool Contains(object item)
        {
            return InnerList.Contains(item);
        }

        public new void Clear()
        {
            InnerList.Clear();
        }

        public new int Count()
        {
            return InnerList.Count;
        }
    }
}