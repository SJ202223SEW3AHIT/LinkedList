using System;
using System.Text;

namespace LinkedList
{
   

    public class LinkList<T> : IList<T> where T: IComparable
    {
        public Node<T> Head { get; protected set; }
		public Node<T> Tail { get; protected set; }

        public bool Contains(T value)
        {
			throw new NotImplementedException();           
        }

        public Node<T> Find(T value)
        {
			throw new NotImplementedException();
        }

        public void Delete(T value)
        {
            throw new NotImplementedException();
        }

        public void InsertFront(T value)
        {
            throw new NotImplementedException();
        }

        public void InsertFront(Node<T> newNode)
        {
            throw new NotImplementedException();
        }

        public void InsertLast(T value)
        {
            throw new NotImplementedException();
        }

        public void InsertLast(Node<T> newNode)
        {
            throw new NotImplementedException();
        }

        public void InsertSorted(T value)
        {
            throw new NotImplementedException();
        }

        public void InsertSorted(Node<T> newNode)
        {
            throw new NotImplementedException();
        }

        public bool IsSorted()
        {
            throw new NotImplementedException();
        }

        public void PrintList()
        {
            throw new NotImplementedException();
        }
        public void PrintListReverse()
        {
            throw new NotImplementedException();
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node<T> temp = Head;
            while (temp != null)
            { 
                sb.Append(String.Format("{0}, ", temp.Data));
                temp = temp.Next;
            }
            return sb.ToString();
        }


        public Node<T> Remove(T value)
        {
            throw new NotImplementedException();
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }

        public Node<T> FindMinRec() {
            throw new NotImplementedException();
        }

        public Node<T> FindMaxRec() {
            throw new NotImplementedException();
        }

        public void PrintListRec() {
            throw new NotImplementedException();
        }

        public void PrintListReverseRec() {
            throw new NotImplementedException();
        }
    }
}
