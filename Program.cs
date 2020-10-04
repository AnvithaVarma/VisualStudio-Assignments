using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {
            var WriteText = "Today class went awesome";
            File.WriteAllText("sample.txt", WriteText); 
        }
    }
}
