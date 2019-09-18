using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.PrintThemWithLimit(int.MaxValue, PrintIt);
        }

        public static int PrintIt(string sValue)
        {
            Console.WriteLine(sValue);
            return 0;
        }
    }
}
