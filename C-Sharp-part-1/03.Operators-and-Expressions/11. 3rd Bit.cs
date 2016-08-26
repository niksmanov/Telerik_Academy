using System;

class Program
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint mask = n >> 3;
        uint check = (mask & 1);

        Console.WriteLine(check);
    }
}
