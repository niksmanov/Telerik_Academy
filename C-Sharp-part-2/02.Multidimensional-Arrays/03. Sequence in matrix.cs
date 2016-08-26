using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class sequenceMatrix
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }
        int[,] matrix = new int[numbers[0], numbers[1]];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string[] cells = Console.ReadLine().Split(' ');
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = int.Parse(cells[col]);
            }
        }

        int maxSeq = 0;
        int curSeq = 1;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            curSeq = 1;
            for (int col = 1; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == matrix[row, col - 1])
                {
                    curSeq++;
                }
                else
                {
                    if (curSeq > maxSeq)
                    {
                        maxSeq = curSeq;
                    }
                    curSeq = 1;
                }
            }
            if (curSeq > maxSeq)
            {
                maxSeq = curSeq;
            }
        }

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            curSeq = 1;
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, col] == matrix[row - 1, col])
                {
                    curSeq++;
                }
                else
                {
                    if (curSeq > maxSeq)
                    {
                        maxSeq = curSeq;
                    }
                    curSeq = 1;
                }
            }
            if (curSeq > maxSeq)
            {
                maxSeq = curSeq;
            }
        }

        Console.WriteLine(maxSeq);
    }
}

