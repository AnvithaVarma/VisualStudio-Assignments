using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class regularExpressions
    {
        static void Main(string[] args)
        {
            Regex example = new Regex(@"\Bher"); //step1

            Match match = example.Match("there is power cut");  // step2

            if (match.Success)                 //step3
            {
                Console.WriteLine("The matched value of the digit is : " + match.Value);
                Console.WriteLine("Matched Properly");
            }
            else
            {
                Console.WriteLine("Does not match");
            }

            

            string test = "aabb";

            if (Regex.IsMatch(test,"^aa"))
            {
                Console.WriteLine("Pattern matched, where string is starting with  ");
            }

            string value = "10 and 20";
            Match mch = Regex.Match(value,@"\d+");
            if(mch.Success)
            {
                Console.WriteLine("Pattern Mtached and the digits are :" + mch.Value);
            }

            mch = mch.NextMatch();
            if(mch.Success)
            {
                Console.WriteLine("The second executed and the digits are :" + mch.Value);
            }
            Console.ReadLine();   
        }

    }
       
}
