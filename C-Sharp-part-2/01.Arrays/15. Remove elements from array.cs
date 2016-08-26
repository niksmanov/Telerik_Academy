using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class removeElements
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int[] longestIncrSeq = new int[n];
        for (int i = 0; i < numbers.Length; i++)
        {
            longestIncrSeq[i] = 1;
        }

        for (int i = 1; i < numbers.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (numbers[j] <= numbers[i])
                {
                    longestIncrSeq[i] = Math.Max(longestIncrSeq[i], longestIncrSeq[j] + 1); 
                }
            }
        }
        Console.WriteLine(n - longestIncrSeq.Max());
    }
}
    
