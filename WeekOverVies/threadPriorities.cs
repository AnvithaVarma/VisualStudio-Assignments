using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPriorities
{
    class threadPriorities
    {
        static long Count1, Count2, Count3, Count4;
        public static void Thread1()
        {
            while (true)
                Count1 += 1;
        }
        public static void Thread2()
        {
            while (true)
                Count2 += 1;
        }
        public static void Thread3()
        {
            while (true)
                Count3 += 1;
        }
        public static void Thread4()
        {
            while (true)
                Count4 += 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started!");
            Thread t1 = new Thread(Thread1);
            Thread t2 = new Thread(Thread2);
            Thread t3 = new Thread(Thread3);
            Thread t4 = new Thread(Thread4);

            t1.Priority = ThreadPriority.Highest;        //thread1 has higher performance
            t2.Priority = ThreadPriority.Lowest;         //thread2 has lowest performance
            t3.Priority = ThreadPriority.AboveNormal;
            t4.Priority = ThreadPriority.BelowNormal;

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();

            Console.WriteLine("Main thread is going to sleep!");
            Thread.Sleep(5000);
            Console.WriteLine("Main Thread Woke Up!");

            t1.Abort();                   //to terminate the thread!    
            t2.Abort(); t3.Abort(); t4.Abort();

            t1.Join();
            t2.Join(); t3.Join(); t4.Join();
            Console.WriteLine("Count1 : " + Count1);
            Console.WriteLine("Count2 : " + Count2);
            Console.WriteLine("Count3 : " + Count3);
            Console.WriteLine("Count4 : " + Count4);
            Console.WriteLine("Main thread Ended!");
        }
    }
}
