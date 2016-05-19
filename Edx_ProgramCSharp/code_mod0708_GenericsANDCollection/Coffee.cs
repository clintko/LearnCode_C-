using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod0708_GenericANDCollection
{
    class Coffee
    {
        private int strength;
        private string bean;
        private string countryOfOrigin;

        public Coffee(int strength, string bean, string country)
        {
            this.Strength = strength;
            this.Bean = bean;
            this.CountryOfOrigin = country;
        } // end constructor

        public int Strength {
            get { return strength; }
            set { strength = value; }
        } // end property Strength

        public string Bean {
            get { return bean;  }
            set { bean = value; }
        } // end property Bean

        public string CountryOfOrigin {
            get { return countryOfOrigin;  }
            set { countryOfOrigin = value; }
        } // end property CountryOfOrigin

    } // end class Coffee
}
