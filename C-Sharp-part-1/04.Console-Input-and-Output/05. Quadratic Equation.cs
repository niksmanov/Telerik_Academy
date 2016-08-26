using System;

    class quadraticEquation
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = (b * b) - (4 * a * c);


            if (d < 0)
            {
                Console.WriteLine("no real roots");
            }
            else if (d == 0)
            {

                double x1 = -b / (2 * a);
                Console.WriteLine("{0:F2}", x1);
            }
            else
            {
               double x1 = (-b - Math.Sqrt(d)) / (2 * a);
               double x2 = (-b + Math.Sqrt(d)) / (2 * a);

                Console.WriteLine("{0:F2}\n{1:F2}", x1, x2);
            }

        }
    }
