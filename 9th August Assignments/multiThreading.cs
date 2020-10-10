using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading
{
    class multiThreading
    {
        string Thread1()
        {
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Thread1 at position " + i);
            }
            return "End of The Thread1" ;
        }

        string Thread2()
        {
            for (int i = 1; i < 6; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("Thread2 sleeping!!");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread2 Woke Up!!");
                }
                Console.WriteLine("Thread2 at position " + i);
            }
            return "End of The Thread2" ;
        }

        string Thread3()
        {
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Thread3 at position " + i);
            }
            return "End of The Thread3";
        }
        static void Main(string[] args)
        {
            multiThreading obj = new multiThreading();

            Thread t1 = new Thread(delegate ()
            {
                Console.WriteLine(obj.Thread1());
            });
            t1.Start();

            Thread t2 = new Thread(delegate ()
            {
                Console.WriteLine(obj.Thread2());
            });
            t2.Start();


            Thread t3 = new Thread(delegate ()
            {
                Console.WriteLine(obj.Thread3());
            });
            t3.Start();

            Console.ReadKey();
        }
    }
}
