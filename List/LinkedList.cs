using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class LinkedList
    {
        public static void Main11()
        {
            LinkedList<int> linkedlist = new LinkedList<int>();

            LinkedListNode<int> node1 = linkedlist.AddFirst(1);
            LinkedListNode<int> node2 = linkedlist.AddFirst(2);
            LinkedListNode<int> node3 = linkedlist.AddLast(3);
            LinkedListNode<int> node4 = linkedlist.AddLast(4);
            LinkedListNode<int> node5 = linkedlist.AddAfter(node1, 5);
            //  node2   node1   node5   node3   node4
            //  (2) <-> (1) <-> (5) <->  (3) <-> (4)
        }
    }
}
