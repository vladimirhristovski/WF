using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_kol
{
    public class Payment
    {
        public decimal baseValue { get; set; }
        public decimal tax { get; set; }

        public Payment(decimal baseValue)
        {
            this.baseValue = baseValue;
            this.tax = Math.Round(baseValue * 0.0114m);
        }

        public override string ToString()
        {
            return $"Уплата {baseValue} Провизија {tax} Вкупно {baseValue+tax}";
        }
    }
}
