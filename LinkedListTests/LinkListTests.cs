using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Tests
{
    [TestClass()]
    public class LinkListTests
    {
        [TestMethod()]
        public void InsertFront()
        {
            int value = 3;
            LinkList<int> l = new LinkList<int>();
            l.InsertFront(value);
            l.PrintList();
            Assert.IsTrue(l.Contains(value));
        }

        [TestMethod()]
        public void InsertLast()
        {
            int value = 10;
            LinkList<int> l = new LinkList<int>();
            l.InsertLast(value);
            l.PrintList();
            Assert.IsTrue(l.Contains(value));
        }
    }
}