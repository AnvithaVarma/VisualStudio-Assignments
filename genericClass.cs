using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class example<T>
    {
        T data;

        public example(T check)
        {
            this.data = check;
        }

        public void Write()
        {
            Console.WriteLine("The data passed to the initiallizer is " + this.data);
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            example<int> result = new example<int>(100);
            example<string> result1 = new example<string>("Anvi");

            result.Write();
            result1.Write();

        }
        
    }
}
