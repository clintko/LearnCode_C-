using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod06_MoreOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager myManager = new Manager();
            myManager.Address = "Taipei";
            myManager.Department = "LifeScience";

            myManager.Login();
            myManager.Hire();
        } // end main
    } // end class
} // end MoreOOP
