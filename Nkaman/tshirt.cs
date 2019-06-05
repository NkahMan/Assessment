using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkaman
{
    public class tshirt : product
    {
        public override double GetTotalPrice()
        {
            switch (size)
            {
                case 's':
                case 'S':
                    return(TotalPrice[0]);
                case 'm':
                case 'M':
                    return(TotalPrice[1]);
                case 'l':
                case 'L':
                    return(TotalPrice[2]);
                default:
                    return(0);
            }
        }
    }
}
