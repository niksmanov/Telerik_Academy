using System;

class variableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int secondA = 5;
        int secondB = 10;
        if (a >= 5)
        {
            secondA = 10;
        }
        if (b >= 10)
        {
            secondB = 5;
        }

        Console.WriteLine("Original values are: {0} and {1}", a, b);
        Console.WriteLine("Exchanged values are: {0} and {1}", secondA, secondB);
    }
}
