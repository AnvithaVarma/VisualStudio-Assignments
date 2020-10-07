using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateExamples
{
    //public delegate void MyDelegate(string msg);

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        MyDelegate del = ClassA.MethodA();
    //        InvokeDelegate(del);

    //        del = ClassB.MethodB();
    //        InvokeDelegate(del);

    //        del = (string msg) => Console.WriteLine("Called lambda expersson" + msg);
    //        InvokeDelegate(del);
    //    }
    //    static void InvokeDelegate(MyDelegate del)
    //    {
    //        del("Hello World");
    //    }
    //}

    //class ClassA
    //{
    //    static void MethodA(string message)
    //    {
    //        Console.WriteLine("called ClassA.MethodA() with parameter : " + message);
    //    }
    //}

    //class ClassB
    //{
    //    static void MethodB(string message)
    //    {
    //        Console.WriteLine("called ClassB.MethodB() with parameter : " + message);
    //    }
    // }

    class rectangle
    {
        public delegate void rectDelegate(double height, double width);

        public void area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", (width * height));
        }
        public static void Main(String[] args)
        {
            rectangle rect = new rectangle();

            rectDelegate rectdele = new rectDelegate(rect.area);

            rectdele.Invoke(6.3, 4.2);
            Console.WriteLine();



        }
    }
}
