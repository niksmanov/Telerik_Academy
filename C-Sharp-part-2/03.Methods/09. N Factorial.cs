using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


    class nFactorial
    {
        static void FactorialOfN(BigInteger n)
        {
            BigInteger factorial = 1;
            for (BigInteger i = 1; i <= n; n--)
            {
                factorial *= n;
            }
            Console.WriteLine(factorial);
        }


        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            FactorialOfN(n);
        }
    }

