using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact=1,i;
            for (i = 1; i <= num; i++)

            fact = i * fact;
            Console.WriteLine($"The factorial of the {num} is {fact}",num,fact);

            if(fact%2==0)
            {
                Console.WriteLine("The given number is not prime ",fact);
            }
            else
            {
                Console.WriteLine("The given number is prime ",fact);

            }

            Console.ReadLine();



        }
    }
}
