using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

    class hexToDecimal
    {
        static BigInteger HextoDecimal(string hexNumber)
        {
            BigInteger decimalNumber = 0;
            int power = 0;
            for (int i = hexNumber.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(hexNumber[i]))
                {
                    decimalNumber += (hexNumber[i] - '0') * (BigInteger)Math.Pow(16, power); // hexadecimal = 16
                    power++;                                                                 // hexNumber from 0 to 9
                }
                else if (char.IsUpper(hexNumber[i])) // Input letters will be uppercase
                {
                    decimalNumber += (hexNumber[i] - 'A' + 10) * (BigInteger)Math.Pow(16, power); // hexadecimal = 16
                    power++;                                                                      // hexNumber from A to Z
                }                                                                               
            }
            return decimalNumber;
        }

        static void Main()
        {
            string hexNumber = Console.ReadLine(); 
            Console.WriteLine(HextoDecimal(hexNumber));
        }
    }
