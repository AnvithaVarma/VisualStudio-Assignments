using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAssign
{
    class delegateExample2
    {
        public delegate double Addnums1Delegate1(int a, int b, int c);
        public delegate string CombineStrings1Delegate1(string a, string b, string c);
        public delegate void Addnums2Delegate2(int a, int b, int c);
        public delegate void CombineStrings2Delegate2(string a, string b, string c);
        public delegate bool CheckLength1Delegate1(string str);
        public delegate bool CheckLength2Delegate2(string str);




        public static double Addnums1(int a,int b,int c)
        {
            return (a + b - c);
        }
        public static string CombineStrings1(string a,string b,string c)
        {
            return (a + b + c);
        }

        public static void Addnums2(int a,int b,int c)
        {
            Console.WriteLine(a + b - c);
        }
        public static void CombineStrings2(string a,string b,string c)
        {
            Console.WriteLine(a + b + c);
        }

        public static bool CheckLength1(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }
        public static bool CheckLength2(string namee)
        {
            if (namee.Length == 3)
                return true;
            return false;
        }



        static void Main(string[] args)
        {
            Addnums1Delegate1 obj1 = new Addnums1Delegate1(Addnums1);
            {
                double result = obj1.Invoke(1, 2, 5);
                Console.WriteLine(result);
            }
            CombineStrings1Delegate1 obj2 = new CombineStrings1Delegate1(CombineStrings1);
            {
                string result1 = obj2.Invoke("I ", " am", " good!");
                Console.WriteLine(result1);
            }

            Addnums2Delegate2 obj3 = new Addnums2Delegate2(Addnums2);
            {
                obj3.Invoke(1, 10, 3);
            }
            CombineStrings2Delegate2 obj4 = new CombineStrings2Delegate2(CombineStrings2);
            {
                obj4.Invoke("Hi ", " smile", " More:)");
            }

            CheckLength1Delegate1 obj5 = new CheckLength1Delegate1(CheckLength1);
            {
                bool result1 = obj5.Invoke("Anvitha");
                Console.WriteLine(result1);
            }
            CheckLength2Delegate2 obj6 = new CheckLength2Delegate2(CheckLength2);
            {
                bool result2 = obj6.Invoke("Ajay");
                Console.WriteLine(result2);
            }



        }
    }
}
