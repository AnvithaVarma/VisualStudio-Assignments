using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singletonDesignPattern
{
    class singleton
    {
        static void Main(string[] args)
        {
            Calculate.Instance.x = 11.11;
            Calculate.Instance.y = 11.11;

            Console.WriteLine($"Addition is: {Calculate.Instance.Addition()}");
            Console.WriteLine("***************************************************");
            Console.WriteLine($"Subtraction is: {Calculate.Instance.Subtraction()}");
            Console.WriteLine("***************************************************");
            Console.WriteLine($"Multiplication is: {Calculate.Instance.Multiplication()}");
            Console.WriteLine("***************************************************");
            Console.WriteLine($"Division is: {Calculate.Instance.Division()}");

            Console.ReadKey();
        }
    }
    public class Calculate
    {
        private Calculate()
        {

        }
        private static Calculate instance = null;
        public static Calculate Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Calculate();
                }
                return instance;
            }
        }
        public double x { get; set; }
        public double y { get; set; }

        public double Addition()
        {
            return x + y;
        }

        public double Subtraction()
        {
            return x - y;
        }

        public double Multiplication()
        {
            return x * y;
        }

        public double Division()
        {
            return x / y;
        }
    }
}
    
        




