using System;

class sequence
{
    static void Main()
    {
        for (int i = 2; i <= 11; i++)
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



