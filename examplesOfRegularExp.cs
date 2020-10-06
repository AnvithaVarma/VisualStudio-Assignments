using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Examples
{
    class examplesOfRegularExp
    {
        static void Main(string[] args)
        {
            //**************Example1****************//
            //Regex regex = new Regex(@"\d+");              //object is created
            //Match match = regex.Match("a678d");           //calling match on regex

            //if(match.Success)                             //test for success
            //{
            //    Console.WriteLine("The digits matched in the given string are : " + match.Value);
            //}

            //**************Example2****************//
            //string input = "/content/alternate-1.aspx";
            //Match match = Regex.Match(input, @"content/([A-Za-z0-9\-]+)\.aspx$",
            //    RegexOptions.IgnoreCase);

            //    if(match.Success)
            //{
            //    string Key = match.Groups[1].Value;
            //    Console.WriteLine(Key);
            //}

            //**************Example3****************//

            //string test = "anvi";
            //if(Regex.IsMatch(test,"^an"))
            //{
            //    Console.WriteLine("The starting letters match!");
            //}
            //if(Regex.IsMatch(test,"ju$"))
            //{
            //    Console.WriteLine("The ending letters match!");
            //}
            //else
            //{
            //    Console.WriteLine("The other letters don't match!");
            //}

            //**************Example4****************//

            //string value = "1 AND 9";

            //Match match = Regex.Match(value, @"\d");

            //if(match.Success)
            //{
            //    Console.WriteLine(match.Value);
            //}
            //match = match.NextMatch();
            //if (match.Success)
            //{
            //    Console.WriteLine(match.Value);
            //}

            //**************Example5****************//


            //Regex regex = new Regex(@"\D+");
            //string result = regex.Replace("abc123456", "zzz");
            //Console.WriteLine($"{result}");

            //**************Example6****************//

            //string test = "/Anvi/varma/";
            //var result1 = Regex.Match(test, "^/.*?/");
            //if(result1.Success)
            //{
            //    Console.WriteLine($"Non-Greedy : {result1}");
            //}
            //var result2 = Regex.Match(test, "^/.*/");
            //if (result2.Success)
            //{
            //    Console.WriteLine($"Greedy : {result2}");
            //}

            //**************Example8****************//

            //string input = "ashjs jdhjsd 1998 hfhf";
            //Match match = Regex.Match(input, @"\d+");
            //if(match.Success)
            //{
            //    int.TryParse(match.Value, out int number);
            //    Console.WriteLine("Numbers are :{0},{1}", number, number + 1);
            //}

            //**************Example9****************//

            //Match m = Regex.Match("123 Axxxxy", @"2.*y");
            //if (m.Success)
            //{
            //    Console.WriteLine("Value  = " + m.Value);
            //    Console.WriteLine("Length = " + m.Length);
            //    Console.WriteLine("Index  = " + m.Index);
            //}

            //**************Example10****************//

            //    static bool IsValid(string value)
            //    {
            //    return Regex.IsMatch(value, @"^[a-zA-Z0-9]*$"); 
            //    }
            //static void Main()
            //{
            //    // Test the strings with the IsValid method.
            //    Console.WriteLine(IsValid("dotnetperls0123"));
            //    Console.WriteLine(IsValid("9otNetPerls'"));
            //    Console.WriteLine(IsValid("500."));
            //    // Console.WriteLine(IsValid(null)); // Throws an exception
            //}

            //**************Example11****************//
            const string value = "ESTA";
            // ... This ignores the case of the "TE" characters.
            if (Regex.IsMatch(value, "es..",
                RegexOptions.IgnoreCase))
            {
                Console.WriteLine(true);
            }



















            Console.ReadLine();
        }
    }
}

