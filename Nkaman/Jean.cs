using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkaman
{
    public class Jean:product
    {
        public override double GetTotalPrice()
        {
            switch (size)
            {
                case 's':
                case 'S':
                    return (TotalPrice[0] + 30);
                case 'm':
                case 'M':
                    return (TotalPrice[1] + 30);
                case 'l':
                case 'L':
                    return (TotalPrice[2] + 30);
                default:
                    return (0);
            }
        }
    }
}
