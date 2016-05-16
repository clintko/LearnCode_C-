using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod04_03Struct
{
    class Program
    {
        struct coffee
        {
            public string grind;
            public string Name { get; set; }
            public string Bean { get; set; }
            public string CountryOfOrigin { get; set; }
            public int Strength { get; set; }
        }
        static void Main(string[] args)
        {
            coffee coffee1 = new coffee();
            coffee1.Name = "Fourth Coffee Quencher";
            coffee1.CountryOfOrigin = "Indonesia";
            coffee1.Strength = 3;
            coffee1.grind = "find";
            Console.WriteLine("Name: {0}", coffee1.Name);
            Console.WriteLine("Country of Origin: {0}", coffee1.CountryOfOrigin);
            Console.WriteLine("Strength: {0}", coffee1.Strength);
            Console.WriteLine("The grind is: {0}", coffee1.grind);

        } // end main
    } // end class
} // namespace
