using System;

class nBit
{
    static void Main()
    {
        int p = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int mask = p >> n;
        int check = (mask & 1);

        Console.WriteLine(check);
    }
}