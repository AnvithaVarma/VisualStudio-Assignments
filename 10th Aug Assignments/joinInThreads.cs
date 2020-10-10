using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingJoin
{
    class Program
    {
        static void Thread1()
        {
            for(int i=1;i<6;i++)
            {
                Console.WriteLine("Thread1 has started for" +i);
            }
            Console.WriteLine("Thread1 has Ended!");
        }
        static void Thread2()
        {
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Thread2 has started for" + i);
            }
            Console.WriteLine("Thread2 has Ended!");
        }
        static void Thread3()
        {
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Thread3 has started for" + i);
            }
            Console.WriteLine("Thread2 has Ended!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstration on Join on MultiThreading");
            Console.WriteLine();
            Console.WriteLine("Main Thread Started!");
            Thread T = new Thread(Thread1);
            Thread T1 = new Thread(Thread2);
            Thread T2 = new Thread(Thread3);
            T.Start();
            T1.Start();
            T2.Start();
            T.Join(); T1.Join(); T2.Join();
            Console.WriteLine("Main Thread Ended!!!!");
        }
    }
}
