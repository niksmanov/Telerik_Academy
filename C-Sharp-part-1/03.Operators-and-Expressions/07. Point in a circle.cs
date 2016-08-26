using System;


class pointInCircle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow(0 - x, 2) + Math.Pow(0 - y, 2));
            //(x - center_x)^2 + (y - center_y)^2 <= radius^2

           
            if (Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2) <= Math.Pow(2, 2))
            {
                Console.WriteLine("yes {0:F2}", distance);
            }
            else
            {
                Console.WriteLine("no {0:F2}", distance);
            }
        }
    }

