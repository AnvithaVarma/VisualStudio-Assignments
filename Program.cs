using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GenericConstraints
{
    class Ruby<T> where T:IDisposable
    {
        public void test1()
        {
            Console.WriteLine("Example of data constraints with IDisposable");
        }

    }
    class C <T> where T: struct
    {
        public void test2()
        {
            Console.WriteLine("Example of data constraints with struct");
        }

    }
    class read<V> where V:class,new()
    {
        public void test3()
        {
            Console.WriteLine("Example of data constraints with constructor");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Ruby<DataTable> ruby = new Ruby<DataTable>();
            C<int> java = new C<int>();
            read<Program> test = new read<Program>();
            ruby.test1();
            java.test2();
            test.test3();
        }
    }
}
