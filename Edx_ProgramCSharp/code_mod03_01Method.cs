using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod03_01Method
{
    class Program
    {
        #region Called Methods
        static void printSomething()
        {
            Console.WriteLine("Print something to the console");
        }

        static int sum(int num01, int num02)
        {
            return num01 + num02;
        }

        static void ReturnMultiOut(out int num, out string str)
        {
            num = 100;
            str = "Using out";
        }

        static void ReturnMultiRef(ref int num, ref string str)
        {
            num = 50;
            str = "Using ref";
        }

        static void Area (int length, int width)
        {
            Console.WriteLine("The area is {0}", length * width);
        }

        static void OptionalParams(int one, int two, string str = "OptionalString")
        {
            Console.WriteLine("{0}, {1}, {2}", one, two, str);
        }
        #endregion
        static void Main(string[] args)
        {
            #region Methods
            // method without input
            //printSomething();

            // method with input parameters
            //int first = 10;
            //int second = 2;
            //int result = sum(first, second);
            //Console.WriteLine("The sum of {0} and {1} is {2}", first, second, result);

            // method often return only one value
            // by using "out", you could return multiple values
            // when using out, the variables must be declaration but do not need to be initialized
            //int first;
            //string second;
            //ReturnMultiOut(out first, out second);
            //Console.WriteLine("{0}, {1}", first, second);

            // Using ref requires that the variables be initialized first
            // unlike "out", the varibles must be initialized before calling the method
            //int first = 10;
            //string second = "";
            //ReturnMultiRef(ref first, ref second);
            //Console.WriteLine("{0}, {1}", first, second);

            // name parameters
            //Area(30, 50);
            //Area(length: 30, width: 50);

            // optional parameters
            OptionalParams(3, 4);
            OptionalParams(3, 4, "InputFromFunctionCall");
            #endregion

        }
    }
}
