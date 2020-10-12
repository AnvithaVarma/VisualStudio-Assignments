using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program 
    {
        static void Main(string[] args)
        {
           
            Dictionary<String, String> dict = new Dictionary<string, string>();
            dict.Add("Category  ",  "Men Fashion");
            dict.Add("List ",  "Women Fashion");
            dict.Add("Accessories",  "Bangles");
            dict.Add("Kids", "Jeans");

            foreach(KeyValuePair<String,String> x in dict)
            {
                Console.WriteLine("The Elements in dictionary are : " + x.Key +"  "  + x.Value);
            }

            Console.WriteLine("Number of elements present are : " +dict.Count());
            dict["FastTrack"] = "Watches";
            foreach (KeyValuePair<String, String> x in dict)
            {
                Console.WriteLine("The Elements in dictionary are : " + x.Key +"  " + x.Value);
            }

           // Console.WriteLine("elements left after being deleted are : " + dict.Remove("List"));
            foreach (KeyValuePair<String, String> x in dict)
            {
                Console.WriteLine("elements left after being deleted are : " + dict.Remove("List"));
            }

            Console.ReadLine();
        }
    }
}
