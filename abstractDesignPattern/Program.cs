using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abstractFactoryExample.factories;

namespace abstractFactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Client Anvitha = new Client(new casualClothes());
            Console.WriteLine($"Anvitha: {Anvitha.DescribeYourClothes()}");

            Client Sravya = new Client(new elegantClothes());
            Console.WriteLine($"Sravya: {Sravya.DescribeYourClothes()}");

            Console.ReadKey();
        }
    }
}
