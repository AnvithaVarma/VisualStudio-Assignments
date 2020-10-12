using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type One
            Type type1 = typeof(object[]);
            // Type Two
            Type type2 = "Anvitha".GetType();
            // Type Three
            int val1 = 50;
            Type type3 = val1.GetType();
            double val2 = 8687987979.8787;
            Type type4 = val2.GetType();

            Console.WriteLine(type1);
            Console.WriteLine(type1.Name);
            Console.WriteLine(type1.BaseType);
            Console.WriteLine(type1.FullName);
            Console.WriteLine("******************************************************************");
            Console.WriteLine(type2);
            Console.WriteLine(type2.Name);
            Console.WriteLine(type2.BaseType);
            Console.WriteLine(type2.FullName);
            Console.WriteLine("******************************************************************");
            Console.WriteLine(type3);
            Console.WriteLine(type3.Name);
            Console.WriteLine(type3.BaseType);
            Console.WriteLine("******************************************************************");
            Console.WriteLine(type4);
            Console.WriteLine(type4.Name);
            Console.WriteLine(type4.BaseType);
        }
    }
}
