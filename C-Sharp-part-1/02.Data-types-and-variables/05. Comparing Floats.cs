using System;

    class comparingFloats
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            if (a - b > eps || b - a > eps)
            {
                Console.WriteLine("false");
            }
            else
                Console.WriteLine("true");

        }
    }
