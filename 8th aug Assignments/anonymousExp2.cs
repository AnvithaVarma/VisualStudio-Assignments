using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousExpressionEg2
{
    class anonymousExp2
    {
        public delegate double Addnums1Delegate1(int a, int b, int c);
        public delegate string CombineStrings1Delegate1(string a, string b, string c);
        public delegate void Addnums2Delegate2(int a, int b, int c);
        public delegate void CombineStrings2Delegate2(string a, string b, string c);
        public delegate bool CheckLength1Delegate1(string str);
        public delegate bool CheckLength2Delegate2(string str);




        static void Main(string[] args)
        {
            Addnums1Delegate1 obj1 = delegate (int a, int b, int c)
            {
                return (a + b - c);
            };
            CombineStrings1Delegate1 obj2 = delegate (string a, string b, string c)
            {
                return a + b + c;
            };
            double result = obj1.Invoke(1, 1, 1);
            Console.WriteLine(result);
            string result1 = obj2.Invoke("Anvi", " is", " good!");
            Console.WriteLine(result1);



            Addnums2Delegate2 obj3 = delegate (int a, int b, int c)
            {
                Console.WriteLine(a + b - c);
            };
            obj3.Invoke(1, 10, 3);
            CombineStrings2Delegate2 obj4 = delegate (string a, string b, string c)
            {
                Console.WriteLine(a + b + c);
            };
            obj4.Invoke("Hi ", " smile", " More:)");



            CheckLength1Delegate1 obj5 = delegate (string name)
             {
                 if (name.Length > 5)
                     return true;
                 return false;
             };
            bool check = obj5.Invoke("Anvitha");
            Console.WriteLine(check);
            CheckLength2Delegate2 obj6 = delegate (string namee)
            {
                if (namee.Length == 3)
                    return true;
                return false;
            };
            bool check1 = obj6.Invoke("Anvitha");
            Console.WriteLine(check1);

        }
    }
}