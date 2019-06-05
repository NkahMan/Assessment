
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkaman
{
    class Program
    {
        static void Main(string[] args)
        {
            var basket = new Basket();

            var tshirt = new tshirt();
            tshirt.Productname = "Comis";
            tshirt.size = 'l';
            basket.Shirts.Add(tshirt);

            var pants = new pants();
            pants.Productname = "DC";
            pants.size = 'l';
            basket.pants.Add(pants);

            var golfer = new Golfer();
            golfer.Productname = "DC Comis";
            golfer.size = 'l';
            basket.Golfes.Add(golfer);

            var jean = new Jean();
            jean.Productname = "DComis";
            jean.size = 'l';
            basket.Jeans.Add(jean);




            Console.WriteLine("Your total price is :"+basket.gettotal());
            Console.ReadKey();

        }
    }
}
