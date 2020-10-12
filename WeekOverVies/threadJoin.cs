using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadJoin
{
    class threadJoin
    {
        static void Test1()
        {
            Console.WriteLine("Thread1 Started!");
            for(int i=1;i<60;i++)
            {
                Console.WriteLine("Test1 : " + i);
            }
            Console.WriteLine("Thread1 Ended!");
        }
        static void Test2()
        {
            Console.WriteLine("Thread2 Started!");
            for (int i = 1; i < 56; i++)
            {
                
                Console.WriteLine("Test2 : " + i);
            }
            Thread.Sleep(10000);
            Console.WriteLine("Thread2 Ended!");
        }
        static void Test3()
        {
            Console.WriteLine("Thread3 Started!");
            for (int i = 1; i < 36; i++)
            {
                Console.WriteLine("Test3 : " + i);
            }
            Console.WriteLine("Thread3 Ended!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started!");
            Thread t1 = new Thread(Test1);       //Thread to call method test1
            Thread t2 = new Thread(Test2);       //Thread to call method test2
            Thread t3 = new Thread(Test3);       //Thread to call method test3
            t1.Start();             //without join, main thread exits in the middle before other thread ends!
            t2.Start();
            t3.Start();
            t1.Join();              //join is used so that main thread exits at last
            t2.Join(3000);        //timeout parameter--main thread will wait for sometime and then exits!
            t3.Join();
            Console.WriteLine("Main Thread Ended!");
        }
    }
}
