using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<T> where T : IComparable
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }

        public Node(){}
        public Node(T value)
        {
            this.Data = value;
            Next = null;
            Previous = null;
        }
    }
}
