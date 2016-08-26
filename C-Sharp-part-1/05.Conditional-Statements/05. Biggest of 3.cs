using System;

class biggestOf3
{
    static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine()); 
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(a,Math.Max(b,c)));
        }
}

