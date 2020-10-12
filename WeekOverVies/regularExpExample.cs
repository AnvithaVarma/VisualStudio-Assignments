using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "9989428899", "99849985", "02812491830", "8747484938" };
            //foreach (string s in str)
            //{

            //    if (s = true)
            //    {
            //        Console.WriteLine($"{s} is a valid number!");
            //    }

            //}
            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid mobile number.", s, isValidMobileNumber(s) ? "is" : "is not");
            }


        }
        public static bool isValidMobileNumber(string inputMobileNumber)
        {
            string strRegex = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9] 
                {2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";

            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputMobileNumber))
                return (true);
            else
                return (false);
        }   
    }
}