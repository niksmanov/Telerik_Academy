using System;


class biggestOf5
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        //Console.WriteLine(Math.Max(a,Math.Max(b,Math.Max(c,Math.Max(d,e)))));

        double max = 0;

        if (a >= b && a >= c && a >= d && a >= e)
        {
            max = a;
        }
        else if (b >= a && b >= c && b >= d && c >= e)
        {
            max = b;
        }
        else if (c >= a && c >= b && c >= d && c >= e)
        {
            max = c;
        }
        else if (d >= a && d >= b && d >= c && d >= e)
        {
            max = d;
        }
        else if (e >= a && e >= b && e >= c && e >= d)
        {
            max = e;
        }
        Console.WriteLine(max);
    }
}
