using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdAExpressionEg2
{
    class lambdaEXAmple
    {
        public delegate double Addnums1Delegate1(double result);
        public delegate string CombineStrings1Delegate1(string result1);
        public delegate void Addnums2Delegate2(double resultt);
        public delegate void CombineStrings2Delegate2(string resultt1);
        public delegate bool CheckLength1Delegate1(string check);
        public delegate bool CheckLength2Delegate2(string check1);




        static void Main(string[] args)
        {
            Func<int,int,int,double> obj1 = (a,b,c) =>
            {
                return (a + b - c);
            };
            double result = obj1.Invoke(1, 1, 1);
            Console.WriteLine(result);
            Func<string,string,string,string> obj2 = (a,b,c) =>
            {
                return a + b + c;
            };
            
            string result1 = obj2.Invoke("Anvi", " is", " good!");
            Console.WriteLine(result1);



            Action<int,int,int> obj3 = (a,b,c) =>
            {
                Console.WriteLine(a + b - c);
            };
            obj3.Invoke(1, 10, 3);
            Action<string,string,string> obj4 = (a, b, c) =>
            {
                Console.WriteLine(a + b + c);
            };
            obj4.Invoke("Hi ", " smile", " More:)");



            Predicate<string> obj5 = (name) =>
            {
                if (name.Length > 5)
                    return true;
                return false;
            };
            bool check = obj5.Invoke("Anvitha");
            Console.WriteLine(check);
            Predicate<string> obj6 = (namee) =>
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