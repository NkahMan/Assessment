using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkaman
{
    public abstract class product
    {
        public string Productname { get; set; }
        public char size { get; set; }
        public double[] TotalPrice = { 10, 20, 30 };
        public abstract double GetTotalPrice();

   
    }
}
