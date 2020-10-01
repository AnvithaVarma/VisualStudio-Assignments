using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class primeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("Given number is not prime");
            }
            else
            {
                Console.WriteLine("Given number is prime");
            }
        }
    }
}
