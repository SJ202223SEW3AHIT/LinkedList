using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 10;
            LinkList<int> l = new LinkList<int>();
            l.InsertLast(value);
            l.PrintList();
            
        }
    }
}
