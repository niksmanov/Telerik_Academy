using System;

class longerval
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long m = long.Parse(Console.ReadLine());
        long result = 0;

        for (long i = n + 1; i < m; i++)
        {
            if (i % 5 == 0)
            {
                result++;
            }
        }
        Console.WriteLine(result);

    }
}

