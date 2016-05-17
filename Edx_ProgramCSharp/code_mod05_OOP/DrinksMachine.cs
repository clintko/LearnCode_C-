using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod05_OOP
{
    class DrinksMachine
    {
        //public string location;
        //public string make;
        //public string model;

        private string location;
        private string make;
        private string model;

        // constructor
        public DrinksMachine(string loc, string make, string model)
        {
            this.Location = loc;
            this.Make = make;
            this.Model = model; 

        } // end constructor

        // property of private variable location
        public string Location
        {
            get { return location;  }
            set { location = value; }
        }

        public string Make
        {
            get { return make;  }
            set { make = value; }
        }

        public string Model
        {
            get { return model;  } 
            set { model = value; }
        }

        public void MakeCappuccino()
        {
            Console.WriteLine("Cappuccino is made");
        } // end method MakeCappuccino

        public void MakeExpresso()
        {
            Console.WriteLine("Expresso is made");
        } // end method MakeExpresso
    } // end class DrinksMachine
} // end namespace Mod05_OOP
