using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class maxNumber
    {
        static void Main(string[] args)
        {
          
            int[] array = new int[10];
            Console.WriteLine("Enter the elements into the array : ");
            for (int i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int large = array[0];
            for (int i = 0; i < 10; i++)
            {
                if (array[i] > large)
                {
                    large = array[i];
                }
            }
            Console.WriteLine($"The largest number is : {large}", large);
            Console.ReadLine();
            
        }

    }
 
}
