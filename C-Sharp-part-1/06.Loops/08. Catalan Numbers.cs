using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

    class catalanNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorial2N = 1;
            BigInteger factorialN1 = 1;
            for (BigInteger i = 1; i <= n; i++)
            {
                factorialN *= i;
            }
            for (BigInteger i = 1; i <= (2 * n); i++)
            {
                factorial2N *= i;
            }
            for (BigInteger i = 1; i <= (n + 1); i++)
            {
                factorialN1 *= i;
            }
            Console.WriteLine(factorial2N / (factorialN1 * factorialN));
        }
    }
