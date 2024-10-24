using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask
{
    internal class StringLINQ
    {

        //LIST AND LINQ
        static List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 10, 6, 7 };
        public static void ProcessNumbers()
        {
            var result = numbers.OrderBy(x => x).ToList();
            Console.WriteLine("Sorted Numbers: " + string.Join(", ", result));
        }

        static void str()
            {
                string[] heroes = { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };

                // Query syntax
                var queryResult = from x in heroes
                                  where x.Contains("a")
                                  select $"{x} contains an 'a'";

                // Method syntax
                var methodResult = heroes
                  .Where(x => x.Contains("a"))
                  .Select(x => $"{x} contains an 'a'");

                // Printing...
                Console.WriteLine("queryResult:");
                foreach (string s in queryResult)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine("\nmethodResult:");
                foreach (string s in methodResult)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }

