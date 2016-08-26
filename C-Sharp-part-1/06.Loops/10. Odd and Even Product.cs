using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class oddEvenProduct
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] num = Console.ReadLine().Split();
        double sumOdd = 1;
        double sumEven = 1;
        for (int i = 0; i < num.Length; i++)
        {
            if (i % 2 == 0)
            {
                sumOdd *= Convert.ToInt32(num[i]);
            }
            else
            {
                sumEven *= Convert.ToInt32(num[i]);
            }
        }
        if (sumEven == sumOdd)
        {
            Console.WriteLine("yes {0}", sumOdd);
        }
        else
        {
            Console.WriteLine("no {0} {1}", sumOdd, sumEven);
        }
    }
}
