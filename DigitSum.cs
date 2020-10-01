using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitsSum
{
    class DigitSum
    {
        static void Main(string[] args)
        {
            int sum=0; 
            Console.WriteLine("Enter the Number whose digits had to be added: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            while (num > 0 || sum>9)
            {
                
                if (num==0)
                {
                    num = sum;
                    sum = 0;
                }
             sum += num % 10;
             num/= 10;
            }
            Console.WriteLine($"Sum of the digits are: {sum}");
            Console.ReadLine();

        }
    }
}
