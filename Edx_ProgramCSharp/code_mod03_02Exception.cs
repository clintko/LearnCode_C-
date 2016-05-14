using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod03_02Exception
{
    
    class Program
    {
        #region Called Method
        static double SafeDivision(double x, double y)
        {
            if (y == 0)
            {
                throw new System.DivideByZeroException();
            }
            return x / y;

        }
        #endregion

        static void Main(string[] args)
        {
            #region Exception Handling
            double a = 98, b = 0;
            double result = 0;
            try
            {
                result = SafeDivision(a, b);
                Console.WriteLine("{0} divided by {1} = {2}", a, b, result);
            }
            catch (DivideByZeroException e)
            {
                //Console.WriteLine("Attempted divided by zero.");
                Console.WriteLine(e);
            }

            #endregion
        } // end class
    } // end program
} // end Mod03_02Exception
