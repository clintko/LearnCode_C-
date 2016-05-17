using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod05_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Module05_OOP");

            // Video 01
            //DrinksMachine myMachine = new DrinksMachine();
            //myMachine.location = "Kitchen";
            //myMachine.model = "DM1000";

            //Console.WriteLine("Location: " + myMachine.location);
            //Console.WriteLine("Make:     " + myMachine.make);
            //Console.WriteLine("Model:    " + myMachine.model);

            // Video02 Encapsulation
            // assign values in constructor
            DrinksMachine myMachine = new DrinksMachine("Kitchen", "Brand", "DM1000");

            // get private value from properties
            Console.WriteLine("Location: " + myMachine.Location);
            Console.WriteLine("Make:     " + myMachine.Make);
            Console.WriteLine("Model:    " + myMachine.Model);

            // call method
            myMachine.MakeCappuccino();
            myMachine.MakeExpresso();
            
        } // end method main
    } // end class
} // end namespace Mod05_OOP
