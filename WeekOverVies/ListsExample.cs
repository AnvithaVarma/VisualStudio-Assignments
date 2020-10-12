using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLists
{
    class ListsExample
    {
        static void Main(string[] args)
        {
           
            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Green");
            colors.Add("Violet");
            colors.Add("Pink");
            colors.Add("White");
            colors.Count();
            colors.Insert(1, "Orange");
            Console.WriteLine("List is Created!");
            
            
            foreach (string color in colors)
            {
                Console.WriteLine($"Elements in List are : {color}");
            }
            Console.WriteLine($"Number of Elements present in List are : " +colors.Count( ));

            colors.Sort();
            Console.WriteLine("List after being sorted is - ");
            foreach (string color in colors)
            {
                Console.WriteLine($"Elements in List are : {color}");
            }

            if (colors.Contains("Blue"))
            {
                Console.WriteLine("Yes! Blue color exists in the list");
            }
            int index = colors.BinarySearch("Pink");
            //Console.WriteLine($"Index of mentioned color is : " +colors.BinarySearch());

            Console.ReadLine();
        }
    }
}
