using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace MultiThreadEg
{
    class multiThreadExample
    {
        public string Thread1()
        {
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Thread1 started at position : " + i);
            }
            return "Thread1 ended";

           
        }
        public string Thread2()
        {
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Thread2 started at position : " + i);
            }
            return "Thread2 ended";
        }
        public string Thread3()
        {
            for (int i = 1; i < 6; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("Thread3 sleeping for 5seconds");
                    Thread.Sleep(5000);
                }
                Console.WriteLine("Thread3 started at position : " + i);
            }
            return "Thread3 ended";
        }




        static void Main(string[] args)
        {
            multiThreadExample obj1 = new multiThreadExample();
            string result = obj1.Thread1();
            Console.WriteLine(result);
            multiThreadExample obj2 = new multiThreadExample();
            string result1 = obj2.Thread2();
            Console.WriteLine(result1);
            multiThreadExample obj3 = new multiThreadExample();
            string result2 = obj3.Thread3();
            Console.WriteLine(result2);

        }
    }
}
