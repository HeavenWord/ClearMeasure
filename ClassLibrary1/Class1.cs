using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public void PrintThemWithLimit(int iUpperLimit, Func<string, int> myPrintFunction)
        {
            bool bIgnore;
            for (int iCntr = 1; iCntr <= iUpperLimit; iCntr++)
            {
                bIgnore = false;
                if (0 == iCntr % 3)
                {
                    myPrintFunction("Fizz");
                    bIgnore = true;
                }
                if (0 == iCntr % 5)
                {
                    myPrintFunction("Buzz");
                    bIgnore = true;
                }
                if (!bIgnore)
                    myPrintFunction(iCntr.ToString());
            }
        }
    }
}
