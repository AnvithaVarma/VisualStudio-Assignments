using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictCities
{
    class dictionaryCities
    {
        static void Main(string[] args)
        {
            Dictionary<int, String> dict = new Dictionary<int, string>();
            dict.Add(1, "Bangalore");
            dict.Add(2, "Mumbai");
            dict.Add(3, "Pune");
            dict.Add(4, "Hyderabad");
            dict.Add(5, "Chennai");
            dict.Add(6, "Delhi");
            Console.WriteLine("The Elements in the Dictionary are :" );
            //foreach (KeyValuePair<int, String> x in dict)
            //{
            //    Console.WriteLine( + x.Key + "   " + x.Value);
            //}

            dict[7] = "Kolkata";
            dict[8] = "Ahmedabad";
            dict[9] = "Noida";
            dict[10] = "Tiruvunantapuram";
            foreach (KeyValuePair<int, String> x in dict)
            {
                Console.WriteLine(+x.Key + "   " + x.Value);
            }

            dict.Remove(1);
           // dict.Remove(2);
           // dict.Remove(3);
           // dict.Remove(4);
           // dict.Remove(5);
           // dict.Remove(6);
            Console.WriteLine(" The cities remained after removing are : ");
            foreach (KeyValuePair<int, String> x in dict)
            {
                Console.WriteLine( +x.Key + "   " + x.Value);
            }


            Console.ReadLine();
        }
    }
}
