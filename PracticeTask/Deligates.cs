using System;
using System.Collections.Generic;
namespace PracticeTask
{
    internal class Delegates
    {
        public delegate decimal DiscountStrategy(decimal price);

        public static class DiscountStrategies
        {
            public static decimal Holiday(decimal price)
            {
                return price - (price * 0.15m); // Apply 15% discount
            }

            public static decimal Clearance(decimal price)
            {
                return price - (price * 0.30m); // Apply 30% discount
            }

           
             
        }
    }   
}
