using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod06_MoreOOP
{
    class Manager : Employee
    {
        private string department;

        public string Department
        {
            get { return department;  }
            set { department = value; }
        }

        public override void Login()
        {
            Console.WriteLine("Manager Login");
        }
        public override void Hire()
        {
            Console.WriteLine("Hire someone");
        }
    }
}
