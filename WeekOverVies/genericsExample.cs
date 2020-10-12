using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInCSharp
{
    class genericsExample
    {
        
    static void Main(string[] args)
        {
            Dictionary<int, string> dObj = new Dictionary<int, string>(5);  //generics used in dictionary

            //add elements to Dictionary  
            dObj.Add(1, "Tom");
            dObj.Add(2, "Jerry");
            dObj.Add(3, "Barbie");
            dObj.Add(4, "Doreamon");
            dObj.Add(5, "Oswald");

            //print data  
            for (int i = 1; i <= dObj.Count; i++)
            {
                Console.WriteLine(dObj[i]);
            }
        }
    }
}
