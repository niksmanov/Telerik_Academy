using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

    class calculate3
    {
        static void Main()
        {

            double n = double.Parse(Console.ReadLine());
            double k = double.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            for (int i = 1; i<=n; i++)
            {
                factorialN *= i;
                if (i<=k)
                {
                    factorialK *= i;
                }
            }
            BigInteger factorialNK = 1;
            for (int i = 1; i<=(n-k); i++)
            {
                factorialNK *= i;
            }
            Console.WriteLine(factorialN/(factorialK*(factorialNK)));
        }
    }

