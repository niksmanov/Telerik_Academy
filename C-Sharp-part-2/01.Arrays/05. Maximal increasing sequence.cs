using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class maxIncrSeq
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int maxIncrSeq = 1;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int incrSeq = 1;
            for (int j = i + 1; j < numbers.Length; j++)
            {

                if (numbers[j] > numbers[j - 1])
                {
                    incrSeq++;
                }
                else
                {
                    if (incrSeq > maxIncrSeq)
                    {
                        maxIncrSeq = incrSeq;
                    }

                    break;
                }
            }

        }
        Console.WriteLine(maxIncrSeq);
    }
}

