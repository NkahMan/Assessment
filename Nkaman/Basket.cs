using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nkaman
{
    public class Basket
    {
        public List<tshirt> Shirts;
        public List<pants> pants;
        public List<Jean> Jeans;
        public List<Golfer> Golfes;
        public Basket()
        {
            Shirts = new List<tshirt>();
            pants = new List<pants>();
            Jeans = new List<Jean>();
            Golfes = new List<Golfer>();
       
        }

      
        public double gettotal()
        {
            double total=0;
            foreach (var t in Shirts) {
                total += t.GetTotalPrice();     
            }
            foreach (var p in pants)
            {
                total += p.GetTotalPrice();
            }
            foreach (var j in Jeans)
            {
                total += j.GetTotalPrice();
            }
            foreach (var g in Golfes)
            {
                total += g.GetTotalPrice();
            }
            return total;

        }

    }
}
