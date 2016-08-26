using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class binaryToDecimal
{
    static BigInteger BinaryToDecimal(string binaryNumbers)
    {
        BigInteger decimalNumber = 0;
        int power = 0;
        for (int i = binaryNumbers.Length - 1; i >= 0; i--)
        {
            decimalNumber += (binaryNumbers[i] - '0') * (BigInteger)Math.Pow(2, power); // binary = 2
            power++;
        }
        return decimalNumber;
    }

    static void Main()
    {
        string binaryNumbers = Console.ReadLine();
        Console.WriteLine(BinaryToDecimal(binaryNumbers));
    }
}
