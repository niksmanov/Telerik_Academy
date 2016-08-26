using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisible_by_7_and_3
{
    class Program
    {
        static void Main()
        {
            var numbers = new int[] { 1, 3, 9, 18, 21, 25, 28, 42, 63 };
            numbers.Where(x => x % 3 == 0 && x % 7 == 0)
                          .ToArray();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("All numbers that are divisible by 7 and 3 are: ");

            var filteredArray = numbers
                .Where(x => x % 3 == 0 && x % 7 == 0)
                .ToList();

            foreach (var number in filteredArray)
            {
                Console.WriteLine(number);
            }
        }
    }
}
