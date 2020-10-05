using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class stackExample
    {
        static void Main(string[] args)
        {
            Stack<int> MyStack = new Stack<int>(); //created an object of stack
            MyStack.Push(2); // push method takes one paramater
            MyStack.Push(4);
            MyStack.Push(6);
            MyStack.Push(8);
            MyStack.Push(10);
            MyStack.Push(12);
            MyStack.Push(14);
            MyStack.Push(16);
            MyStack.Push(18);
            MyStack.Push(20);
            Console.WriteLine("The elements of stack are: ");
            foreach (int stack in MyStack)
            {
                Console.WriteLine( + stack);
            }

            MyStack.Pop();
            MyStack.Pop();
          //  MyStack.Pop();
          //  MyStack.Pop();
           // MyStack.Pop();
           // MyStack.Pop();
            Console.WriteLine("The elements of stack remained after pop of elements are: ");
            foreach (int stack in MyStack)
            {
                Console.WriteLine(+stack);
            }

            Console.WriteLine("The peek element of stack is :" + MyStack.Peek());
            
        }
    }
}
