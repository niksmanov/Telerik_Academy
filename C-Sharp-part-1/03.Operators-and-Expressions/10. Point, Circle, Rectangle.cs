﻿using System;

    class pointCircleRectangle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool circle = Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2) <= Math.Pow(1.5, 2);
            bool rectangle = (x >= -1 && x <= 5) && (y >= -1 && y <= 1);

            if (circle && !rectangle)
            {
                Console.WriteLine("inside circle outside rectangle");
            }
            else if (!circle && rectangle)
            {
                Console.WriteLine("outside circle inside rectangle");
            }
            else if (circle && rectangle)
            {
                Console.WriteLine("inside circle inside rectangle");
            }
            else
            {
                Console.WriteLine("outside circle outside rectangle");
            }
        }
    }
