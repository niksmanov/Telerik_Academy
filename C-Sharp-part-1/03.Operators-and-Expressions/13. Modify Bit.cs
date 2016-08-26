using System;

class modifyBit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        if (v == 0)
        {
            int result = n & (~(1 << p));
            Console.WriteLine(result);
        }
        else
        {
            int result = n | (1 << p);
            Console.WriteLine(result);
        }
    }
}
