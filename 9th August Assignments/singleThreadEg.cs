using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleThreadExample
{
    class singleThreadEg
    {
        public string Thread()
            
        {
             return "Thread1 has started!";           
        }
        
        public string Thread2()
        {
            return "Thread2 has started!";
        }

        static void Main(string[] args)
        {
            singleThreadEg obj = new singleThreadEg();
            string result = obj.Thread();
              Console.WriteLine(result);
            

            singleThreadEg obj2 = new singleThreadEg();
            string result2 = obj2.Thread2();
            Console.WriteLine(result2);


        }
    }
}
