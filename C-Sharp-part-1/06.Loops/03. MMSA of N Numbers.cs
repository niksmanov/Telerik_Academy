using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class mmsaOfN
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double max = double.MinValue;
        double min = double.MaxValue;
        double sum = 0;
        for (double i = 1; i <= n; i++)
        {
            double variable = double.Parse(Console.ReadLine());
            if (variable > max)
            {
                max = variable;
            }
            if (variable < min)
            {
                min = variable;
            }
            sum += variable;
        }
        Console.WriteLine("min={0:F2}", min);
        Console.WriteLine("max={0:F2}", max);
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", sum / n);
    }
}
