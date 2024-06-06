using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_kol1_2
{
    public class Lap
    {
        public decimal minutes {  get; set; }
        public decimal seconds { get; set; }

        public Lap(decimal minutes, decimal seconds)
        {
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public override string ToString()
        {
            return String.Format("{0}:{1}",minutes,seconds);
        }
    }
}
