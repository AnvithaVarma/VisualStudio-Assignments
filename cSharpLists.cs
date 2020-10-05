using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class cSharpLists
    {
        static void Main(string[] args)
        {
            SortedList<int, String> numbers = new SortedList<int, string>();

            numbers.Add(10, "Ten");
            numbers.Add(2, "Two");
            numbers.Add(4, "Four");
            numbers.Add(8, "Eight");
            
            
            Console.WriteLine("Elements after sorted are : ");
            foreach( var check in numbers)
            {
                Console.WriteLine( $" { "Key:{0}, Value:{1}" }", check.Key, check.Value );
            }

            numbers.Remove(2);
            Console.WriteLine("Elements left after removing are : ");
            foreach (var check in numbers)
            {
                Console.WriteLine($" { "Key:{0}, Value:{1}" }", check.Key, check.Value);
            }
            Console.WriteLine("Number of Elements present are :" +numbers.Count());

            Console.ReadLine();
        }
    }
}
