using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class matrixNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int countCol = 1;

        for (int row = 1; row <= n; row++)
        {
            for (int col = row; col < 2 * n; col++)
            {
                if (countCol <= n)
                {
                    Console.Write(col + " ");
                    countCol++;
                }
            }
            Console.WriteLine();
            countCol = 1;
        }
    }
}
