using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class leapYear
    {
        static void Main()
        {
            int year = int.Parse(Console.ReadLine());
            var result = DateTime.IsLeapYear(year);

            if (result == true)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }             
        }
    }
