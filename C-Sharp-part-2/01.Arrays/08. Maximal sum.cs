using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class maxSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int currentSum = 0;
        int maxSum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            currentSum += numbers[i];

            if (currentSum < 0)
            {
                currentSum = 0;
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }
        Console.WriteLine(maxSum);

    }
}

