using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_kol
{

    public class Student
    {
        public string name { get; set; }
        public string index { get; set; }
        public List<Payment>payments { get; set; }

        public Student(string name, string index)
        {
            this.name = name;
            this.index = index;
            this.payments = new List<Payment>();
        }

        public decimal getTotalPayments()
        {
            decimal total = 0;
            foreach (var payment in payments)
            {
                total += payment.baseValue;
            }
            return total;
        }

        public decimal getTotalTax()
        {
            decimal total = 0;
            foreach (var payment in payments)
            {
                total += payment.tax;
            }
            return total;
        }

        public string Details()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(index).Append(" ").Append(name).Append("\n");
            for(int i = 0; i < payments.Count; i++)
            {
                sb.Append(i+1).Append(" ").Append(payments[i].ToString()).Append("\n");
            }
            sb.Append("Вкупно уплати ").Append(getTotalPayments()).Append("\n");
            sb.Append("Вкупно провизија ").Append(getTotalTax());
            return sb.ToString();
        }

        public override string ToString()
        {
            return $"{index} {name}";
        }
    }
}
