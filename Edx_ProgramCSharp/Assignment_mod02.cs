using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod2_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int idx01 = 0; idx01 < 8; idx01++)
            {
                for (int idx02 = 0; idx02 < 8; idx02++)
                {
                    if ((idx01 + idx02) % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O");
                    } // end if-else
                } // end inner for loop
                Console.WriteLine();
            } // end outer for loop
        } // end main
    } // end class
} // end namespace
