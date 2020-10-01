using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumBetweenRange
{
    class primeNumBetRange
    {
        static void Main(string[] args)
        {
            int i,j, count= 0;
            Console.WriteLine("Prime numbers between 1 and 100 are  : ");

            for (i = 1; i <= 100; i++)
            {
                count = 0;
                if (i > 1)
                {
                    for (j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            count = 1;
                            break;
                        }
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine($"{+i}");

                }
            }  
                Console.ReadLine();
        }
    }
}

