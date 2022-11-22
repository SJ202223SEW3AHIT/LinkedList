using System;


namespace LinkedList
{
 

    public interface IList<T> where T: IComparable
    {
        //Add a Node
        void InsertFront(Node<T> newNode);
        void InsertLast(Node<T> newNode);
        void InsertSorted(Node<T> newNode);

        //Add a Value
        void InsertFront(T value);
        void InsertLast(T value);
        void InsertSorted(T value);

        //Print
        void PrintList();
        void PrintListReverse();

        //Search and ...
        bool Contains(T value);
        Node<T> Find(T value);
        //Find Minimum & Maximum Recursive
        Node<T> FindMinRec();
        Node<T> FindMaxRec();

        //Remove: remove the node from the list and return it
        Node<T> Remove(T value);
        
        //Delete: remove the node from the list and delete it
        void Delete(T value);

        //Sort
        void Sort(); //Use a strategy Pattern with a SortBehavior
        //Returns true if the whole list is sorted
        bool IsSorted();
        //Print Recursive
        void PrintListRec();
        void PrintListReverseRec();
     
    }
}
