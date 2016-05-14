/**
 * Edx Programmgin with C#
 * Module Two
 * Making Decision and Performing iterations
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod02_Code
{
    class Program {

        static long Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        } // end Factorial
        static void Main(string[] args) {
            #region Decision Statements
            int condition1;
            int condition2;
            int switchCondition;
            // if sample
            //condition1 = 1;
            //if (condition1 == 1) {
            //    Console.WriteLine("Comparison evaluated to true");
            //} // end if
            //Console.WriteLine("This executes after the if, regardless of condition");

            // if-else sample
            //condition1 = 3;
            //if (condition1 == 1)
            //{
            //    Console.WriteLine("comparison evaluated to true");
            //}
            //else
            //{
            //    Console.WriteLine("comparison evaluated to false");
            //}

            // switch statement
            //switchCondition = 3;
            //switch(switchCondition)
            //{
            //    case 1:
            //        Console.WriteLine("Value is 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("Value is 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("Value is 3");
            //        break;
            //    default:
            //        Console.WriteLine("Value is not 1, 2, 3");
            //        break;
            //} // end switch
            #endregion

            #region Repetition Statements
            int whileCounter = 0;
            int doCounter = 0;

            // for loop sample
            //Console.WriteLine("for loop");
            //Console.WriteLine();
            //for (int forCounter = 0; forCounter < 10; forCounter++)
            //{
            //    Console.WriteLine("forCounter is at " + forCounter);
            //} // end for loop

            // while loop sample
            //while(whileCounter < 5)
            //{
            //    Console.WriteLine("whileCounter is at " + whileCounter++);
            //} // end while loop

            // do while sample
            //do
            //{
            //    Console.WriteLine("doCounter is at " + doCounter++);
            //} while (doCounter < 5);

            // recursive
            long value = Factorial(10);
            Console.WriteLine(value);
            
             // end Factorial
            #endregion

        } // end main
    } // end class Program
} // end namespace mod02_Code
