using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    internal class Planets
    {
        //instans
        private string name;


        //encaptulations
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        //constructor
        private Planets()
        {

        }
        public Planets(string name):this()
        {
            this.name = name;
        }

        //Override ToString
        public override string ToString()
        {
            return name;
        }

    }
}
