using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumBetweenRange
{
    class numBetweenrange
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the lowest range : ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the highest range : ");
            int h = Convert.ToInt32(Console.ReadLine());
           
                Console.WriteLine("The numbers in the given range are : ");
            for (n = l; n <= h; n++)
                Console.WriteLine($"{+n}");
            Console.ReadLine();
        }
    }
}
