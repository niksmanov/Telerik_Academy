using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class decimalBinary
    {
        static void Main()
        {

            long decimalNum = long.Parse(Console.ReadLine());
            string binary = string.Empty;
            long result = 0;
            long quotient = 1;
            while (quotient != 0)
            {
                result = decimalNum % 2;
                quotient = decimalNum / 2;
                binary += result.ToString();
                decimalNum = quotient;
            }
            char[] valueChars = binary.ToCharArray();
            Array.Reverse(valueChars);
            for (int i = 0; i < binary.Length; i++)
            {
                Console.Write("{0}", valueChars[i]);
            }
            Console.WriteLine();
        }
    }
