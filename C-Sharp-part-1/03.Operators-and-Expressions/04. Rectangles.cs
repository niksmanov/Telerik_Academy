using System;

class Rectangles
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double perimeter = (a + b) * 2;
            double area = a * b;

            Console.WriteLine("{0:F2} {1:F2}", area, perimeter);

        }
    }
