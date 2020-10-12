using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadLock
{
    class threadLock
    {
        public void Thread1()
        {
            lock (this)
            {
                Console.Write("[I am a very good girl, ");
                Thread.Sleep(5000);
                Console.WriteLine("tell to my teacher!!!] ");
            }
        }
        
        static void Main(string[] args)
        {
            threadLock p = new threadLock();          //instance of class
            Thread t1 = new Thread(p.Thread1);   //calling non-static method using thread1
            Thread t2 = new Thread(p.Thread1);   //calling non-static method using thread2 

            t1.Start();
            t2.Start();

        }
    }
}
