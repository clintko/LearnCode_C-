using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod04_01Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // One dimensional array
            //int[] arrInt01 = new int[10];
            //arrInt01[0] = 10;
            //arrInt01[1] = 20;

            //int[] arrInt02 = { -1, -2, -3, -4, -5 };
            //for (int idx = 0; idx < arrInt02.Length; idx++)
            //{
            //    Console.WriteLine(arrInt02[idx]);
            //} // end for loop

            // two dimensional array
            int[,] arr2DInt01 = { {3, 2}, {4, 10}, {11, 15} };
            
            for (int idx1 = 0; idx1 < arr2DInt01.GetLength(0); idx1++)
            {
                for (int idx2 = 0; idx2 < arr2DInt01.GetLength(1); idx2++)
                {
                    Console.Write(arr2DInt01[idx1, idx2] + " ");
                } // end inner for loop
                Console.WriteLine();
            } // end outer for loop
        } // end main
    } // end program
} // namespace
