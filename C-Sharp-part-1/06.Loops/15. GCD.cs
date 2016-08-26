using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GCD
{
    static void Main()
    {
        string numberString = Console.ReadLine();
        string[] number = numberString.Split(' ');
        double a = Math.Abs(Convert.ToInt32(number[0]));
        double b = Math.Abs(Convert.ToInt32(number[1]));

        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }

        if (a == 0)
            Console.WriteLine(b);
        else
            Console.WriteLine(a);
    }
}