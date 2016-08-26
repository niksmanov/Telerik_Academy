using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class binaryShort
{
    static int[] BinaryShort(short decimalNumber)
    {
        int[] bitRepresent = new int[16]; // 16-bit signed integer
        for (short i = 0; i < bitRepresent.Length; i++)
        {
            bitRepresent[i] = (decimalNumber >> i) & 1; // (decimalNumber / i) % 2; 
        }                                               // can't devide by 0
        Array.Reverse(bitRepresent);

        return bitRepresent;
    }
    static void Main()
    {
        short decimalNumber = short.Parse(Console.ReadLine());
        Console.WriteLine(String.Join("", BinaryShort(decimalNumber)));
    }
}
