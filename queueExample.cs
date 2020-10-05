using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class queueExample
    {
        static void Main(string[] args)
        {
            Queue<String> MyQueue = new Queue<String>();
            MyQueue.Enqueue("Programming");
            MyQueue.Enqueue("is Fun!");
            MyQueue.Enqueue("Trained ");
            MyQueue.Enqueue("by Sachin");
            Console.WriteLine("The Elements present in queue are : ");

            foreach (String queue in MyQueue)
            {
                Console.WriteLine($"{ queue}");
            }
            MyQueue.Dequeue();
            MyQueue.Dequeue();
            Console.WriteLine("The Elements after removing some elements from queue are : ");

            foreach (String queue in MyQueue)
            {
                Console.WriteLine($"{ queue}");
            }
            Console.WriteLine($"The peek Element after removing some elements from queue are : { MyQueue.Peek()}");
            Console.ReadLine();
        }
    }
}
