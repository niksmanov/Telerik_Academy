using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class triangleSurfaceByTwoSides
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double degree = double.Parse(Console.ReadLine());
        double angle = Math.PI * degree / 180;

        double result = (a * b * Math.Sin(angle) / 2);
        Console.WriteLine("{0:F2}", result);
    }
}