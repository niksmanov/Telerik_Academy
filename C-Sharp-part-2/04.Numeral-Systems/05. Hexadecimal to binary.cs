using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class hexToBinary
{
    static string HexToBinary(string hexNumber)
    {
        BigInteger hexToDec = 0;  // Convert hex to decimal          
        int power = 0;
        for (int i = hexNumber.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(hexNumber[i]))
            {
                hexToDec += (hexNumber[i] - '0') * (BigInteger)Math.Pow(16, power); // hexadecimal = 16
                power++;                                                            // hexNumber from 0 to 9
            }
            else if (char.IsUpper(hexNumber[i])) // Input letters will be uppercase
            {
                hexToDec += (hexNumber[i] - 'A' + 10) * (BigInteger)Math.Pow(16, power); // hexadecimal = 16
                power++;                                                                 // hexNumber from A to Z
            }
        }
        string result = string.Empty; // Convert decimal to binary
        do
        {
            BigInteger bit = hexToDec % 2;
            result = bit + result;
            hexToDec /= 2;

        } while (hexToDec != 0);
        return result;
    }
    static void Main()
    {
        string hexNumber = Console.ReadLine();
        Console.WriteLine(HexToBinary(hexNumber));

    }
}
