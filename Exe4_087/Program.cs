using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_087
{
    class Node
    {
        public int info;
        public Node next;
        public Node(int i, Node n)
        {
            info = i;
            next = n;
        }
    }

    class Stack
    {
        private int[] farhan = new int[105];

        Node top;

        public Stack()
        {
            top = null;
        }
        static void Main(string[] args)
        {
        }
    }
}
