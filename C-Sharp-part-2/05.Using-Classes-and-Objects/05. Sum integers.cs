using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class sumIntegers
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int sum = 0;
        foreach (var number in input)
        {
            sum += int.Parse(number);
        }
        Console.WriteLine(sum);
    }
}
