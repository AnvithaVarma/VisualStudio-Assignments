using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calculator" in both code and config file together.
    public class Calculator : ICalculator
    {
        public int sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public int subtract(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1 - num2;

            }
            else
            {
                return 0;
            }
            
        }
        public int multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public int divide(int num1, int num2)
        {
            if(num2 !=0)
            {
                return num1 / num2;

            }
            else
            {
                return 0;
            }
        }
    }
}
