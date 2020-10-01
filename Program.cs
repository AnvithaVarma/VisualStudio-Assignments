using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("The first ten natural numbers are : ");
            for (i = 1; i <= 10; i++)
            {
               Console.WriteLine($"{+i}");
                Console.WriteLine("\n");

            }
            Console.ReadLine();


        }
    }
}
