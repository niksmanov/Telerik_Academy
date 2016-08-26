using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class calculate
{
    static void Main()
    {


        int n = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        int factorial = 1;
        double sum = 1;
        double pow = 0;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            pow = Math.Pow(x, i);
            sum += (factorial / pow);
        }

        Console.WriteLine("{0:F5}", sum);
    }
}

