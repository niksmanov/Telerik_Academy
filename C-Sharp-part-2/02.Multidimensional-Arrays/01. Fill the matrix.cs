using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class fillmatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        char someChar = char.Parse(Console.ReadLine());
        int index = 1;

        if (someChar == 'a')
        {
            for (int row = 0; row < n; row++) // 0 = Rows dimension
            {
                for (int col = 0; col < n; col++) // 1 = Cols dimension
                {
                    matrix[row, col] = index++;
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == n - 1)
                    {
                        Console.Write(matrix[col, row]);
                    }
                    else
                    {
                        Console.Write(matrix[col, row] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        if (someChar == 'b')
        {
            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = index++;
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                    {
                        matrix[row, col] = index++;
                    }
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == n - 1)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    else
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        if (someChar == 'c')
        {
            int r = n - 1;
            int c = 0;
            int StartRow = n - 1;
            int StartCol = 0;
            matrix[r, c] = 1;

            while (index < n * n)
            {
                if (r == (n - 1) && c < (n - 1))
                {
                    StartRow--;
                    StartCol = 0;
                    r = StartRow;
                    c = StartCol;
                    index++;
                    matrix[r, c] = index;

                    while (r < (n - 1) && c < (n - 1))
                    {
                        r++;
                        c++;
                        index++;
                        matrix[r, c] = index;
                    }
                }
                if (r <= (n - 1) && c == (n - 1))
                {
                    StartRow = 0;
                    StartCol++;
                    r = StartRow;
                    c = StartCol;
                    index++;
                    matrix[r, c] = index;


                    while (c < (n - 1))
                    {
                        r++;
                        c++;
                        index++;
                        matrix[r, c] = index;
                    }
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == n - 1)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    else
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        if (someChar == 'd')
        {
            int offset = 0;
            int Row = 0;
            int Col = 0;

            while (index <= n * n)
            {
                for (Row = offset; Row < n - offset; Row++)
                {
                    Col = offset;
                    matrix[Row, Col] = index;
                    index++;
                }
                for (Col = 1 + offset; Col < n - offset; Col++)
                {
                    Row = n - 1 - offset;
                    matrix[Row, Col] = index;
                    index++;
                }
                for (Row = n - 2 - offset; Row >= offset; Row--)
                {
                    Col = n - 1 - offset;
                    matrix[Row, Col] = index;
                    index++;
                }
                for (Col = n - 2 - offset; Col >= offset + 1; Col--)
                {
                    Row = offset;
                    matrix[Row, Col] = index;
                    index++;
                }
                offset++;
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == n - 1)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    else
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}


