using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

    class decimalToBinary
    {
        static string DecimalToBinary(BigInteger decimalNumber)
        {
            string result = string.Empty;
            do
            {
                BigInteger bit = decimalNumber % 2; // binary = 2
                result = bit + result;
                decimalNumber /= 2;

            } while (decimalNumber != 0);
            return result;
        }

        static void Main()
        {
            BigInteger decimalNumber = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToBinary(decimalNumber));
        }
    }

