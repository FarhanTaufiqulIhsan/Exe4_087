using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_087
{
    
    class Stack
    {
        private char[] farhan = new char[105];
        private char top;
        private char max;
        public Stack(char size)
        {
            farhan = new char[size];
            top = -1;
            max = size;
        }

        public void push(int item)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack overflow");
            }
        }
        
        static void Main(string[] args)
        {
        }
    }
}
