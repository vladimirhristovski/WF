using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_kol1_2
{
    public class Driver
    {
        public string name { get; set; }
        public List<Lap> laps { get; set; }
        public bool firstDriver { get; set; }
        public decimal age { get; set; }

        public Driver(string name, decimal age, bool firstDriver)
        {
            this.name = name;
            this.firstDriver = firstDriver;
            this.age = age;
            this.laps = new List<Lap>();
        }

        public string getFirstDriverStatus()
        {
            if (firstDriver)
            {
                return "F";
            }
            else
            {
                return "S";
            }
        }

        public override string ToString()
        {
            return String.Format("{0} ({1}) - {2}", name, age,getFirstDriverStatus());
        }
    }
}
