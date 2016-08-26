using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class binaryToHexadecimal
{
    const string HexDigits = "0123456789ABCDEF";
    static string BinaryToHex(string binaryNumber)
    {
        BigInteger binaryToDec = 0; // Convert binary to decimal
        int power = 0;
        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            binaryToDec += (binaryNumber[i] - '0') * (BigInteger)Math.Pow(2, power); // binary = 2
            power++;
        }
        string result = string.Empty; // Convert decimal to hex
        do
        {
            BigInteger value = binaryToDec % 16; // hexadecimal = 16
            result = HexDigits[(int)value] + result;
            binaryToDec /= 16;

        } while (binaryToDec != 0);
        return result;
    }

    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        Console.WriteLine(BinaryToHex(binaryNumber));
    }
}
