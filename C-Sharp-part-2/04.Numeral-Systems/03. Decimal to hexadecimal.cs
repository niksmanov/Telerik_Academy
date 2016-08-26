using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class decimalToHex
{
    const string HexDigits = "0123456789ABCDEF";

    static string DecimalToHex(BigInteger decimalNumber)
    {
        string result = string.Empty; 
        do
        {
           BigInteger value = decimalNumber % 16; // hexadecimal = 16
           result = HexDigits[(int)value] + result;
           decimalNumber /= 16;
            
        } while (decimalNumber != 0);
        return result;
        
    }
    static void Main()
    {
        BigInteger decimalNumber = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine(DecimalToHex(decimalNumber));

    }
}
  
