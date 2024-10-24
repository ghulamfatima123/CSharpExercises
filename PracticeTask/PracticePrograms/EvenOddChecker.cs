using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask.PracticePrograms
{
    internal class EvenOddChecker
    {
        public void numberchecker() { 
        Console.WriteLine("write a number :");
        try
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }

            else
            {
                Console.WriteLine("Odd Number");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }}
}
