using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod04_02Enum
{
    class Program
    {
        // note: enumeration can not be declared inside method
        //enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        //enum Days { Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};
        enum Days { Sunday = -1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        static void Main(string[] args)
        {
        int x = (int)Days.Sunday;
        int y = (int)Days.Friday;
        Console.WriteLine("Sun = " + x);
        Console.WriteLine("Fri = " + y);
    } // end main
    } // end class
} // end namespace
