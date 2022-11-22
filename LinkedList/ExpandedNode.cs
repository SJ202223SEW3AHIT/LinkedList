using System;

namespace LinkedList
{
    class ExpandedNode<K, T> : Node<K> where K : IComparable
    {
        public T ExpandedData { get; set; }

        public ExpandedNode(K data, T expandedData)
        {
            base.Data = data;
            this.ExpandedData = expandedData;
            base.Next = null;
            base.Previous = null;
        }
    }
}
