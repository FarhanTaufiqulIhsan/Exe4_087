using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_087
{
    class Node
    {
        public char info;
        public Node next;
        public Node(char i, Node n)
        {
            info = i;
            next = n;
        }

    }

    class Stack
    {
        private char[] farhan = new char[105];

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
