using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConstructorsInThread
{
   // public delegate string Test(string obj);
    class constructorInThread
    {
        static void Test(object max)
        {
            int num = Convert.ToInt32(max);
            for (int i = 1; i < num; i++)
            {
                Console.WriteLine("Thread1 has started!");
                Console.WriteLine("Test" + i);

            }
            Console.WriteLine("Thread1 has Ended!");
            // return "Test has ended";
        }
            static void Test1(object min)
            {
            int nums = Convert.ToInt32(min);
            for (int i = 1; i < nums; i++)
                {
                    Console.WriteLine("Thread2 has started!");
                    Console.WriteLine("Test1" + i);

                }
                Console.WriteLine("Thread2 has Ended!");
            }
        



        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread started!");
            //Thread t = new Thread(new ThreadStart(Test));
            //Thread t1 = new Thread(new ThreadStart(Test1));//instance of thread
            //ThreadStart obj = () => Test();   //using lambda expression!
            //ThreadStart obj1 = () => Test1();// using lambda expression
            
            ParameterizedThreadStart obj = new ParameterizedThreadStart(Test); 
            
            ParameterizedThreadStart obj1 = new ParameterizedThreadStart(Test1);
            Thread t = new Thread(obj);
            Thread t1 = new Thread(obj1);
            t.Start(5);
            t1.Start(6);
            //Test();
            //Test1();
            Console.WriteLine("Main Thread Ended!");
            Console.ReadLine();
        }
    }
}
