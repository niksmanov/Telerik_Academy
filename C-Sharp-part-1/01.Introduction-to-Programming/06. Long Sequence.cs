using System;

class longSequence
{
    static void Main()
    {
        for (int i = 2; i <= 1001; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else if (i % 2 == 1)
            {
                Console.WriteLine(i * -1);
            }
        }
    }
}
