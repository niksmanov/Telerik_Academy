using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class oneSystemToOthers
{
    const string HexDigits = "0123456789ABCDEF";

    static string OneSystemToOthers(int inputNumberBase, string inputNumber, int outputNumberBase)
    {
        BigInteger anyToDec = 0; // any numeral system to decimal

        foreach (char digit in inputNumber)
        {
            anyToDec =  HexDigits.IndexOf(digit.ToString()) + anyToDec * inputNumberBase;
        }

        //int power = 0;            // This solution give 85 / 100
        //for (int i = inputNumber.Length - 1; i >= 0; i--)
        //{
        //    if (char.IsDigit(inputNumber[i]))
        //    {
        //        anyToDec += (inputNumber[i] - '0') * (BigInteger)Math.Pow(inputNumberBase, power); // input number base
        //        power++;                                                                           // hexNumber from 0 to 9
        //    }
        //    else if (char.IsUpper(inputNumber[i])) // Input letters will be uppercase
        //    {
        //        anyToDec += (inputNumber[i] - 'A' + 10) * (BigInteger)Math.Pow(inputNumberBase, power); // input number base
        //        power++;                                                                                // hexNumber from A to Z
        //    }
        //}

        string result = string.Empty; // decimal to any other numeral system
        do
        {
            BigInteger decToAny = anyToDec % outputNumberBase; // output number base

            result = HexDigits[(int)decToAny] + result;
            anyToDec /= outputNumberBase;

        } while (anyToDec != 0);
        return result;
    }

    static void Main()
    {
        int inputNumberBase = int.Parse(Console.ReadLine()); // in which numeral system is input number
        string inputNumber = Console.ReadLine();
        int outputNumberBase = int.Parse(Console.ReadLine()); // in which numeral system should be output number
        Console.WriteLine(OneSystemToOthers(inputNumberBase, inputNumber, outputNumberBase));
    }
}
