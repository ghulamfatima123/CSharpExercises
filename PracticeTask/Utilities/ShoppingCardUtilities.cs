using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask.Utilities
{
    internal class ShoppingCardUtilities
    {

        public const decimal taxLimit = 0.01m;
        public static decimal countDiscount(decimal price)
        {
            Console.WriteLine("count discount");
            price = price + (price * taxLimit);
            Console.WriteLine(price);
            return price;
        }
    }
}
