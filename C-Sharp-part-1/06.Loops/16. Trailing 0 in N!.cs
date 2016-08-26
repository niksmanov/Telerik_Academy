using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

    class trailing0inN
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            int trailingZero = 0;
            while (Math.Pow(5, k) < n)
            {
                k++;
                trailingZero += n / (int)(Math.Pow(5, k));
            }
            Console.WriteLine(trailingZero);
        }
    }

