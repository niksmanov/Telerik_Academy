using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class triangleSurface
    {
        static void Main()
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal hA = decimal.Parse(Console.ReadLine());
            var result = (a * hA) / 2;
            Console.WriteLine("{0:F2}", result);

        }
    }
