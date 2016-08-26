using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class maximalSequence
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int currentSeq = 1;
        int maxSeq = 1;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                currentSeq++;
            }
            else
            {
                currentSeq = 1;
            }
            if (currentSeq > maxSeq)
            {
                maxSeq = currentSeq;
            }
        }

        Console.WriteLine(maxSeq);
    }
}

