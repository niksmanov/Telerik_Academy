namespace Matrix
{
    using System;

    public class GenerateMatrix
    {
        public static void ChangeMatrix(ref int row, ref int col)
        {
            int[] directionRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionCol = { 1, 0, -1, -1, -1, 0, 1, 1 };

            int cd = 0;

            for (int count = 0; count < 8; count++)
            {
                if (directionRow[count] == row && directionCol[count] == col)
                {
                    cd = count;
                    break;
                }
            }

            if (cd == 7)
            {
                row = directionRow[0];
                col = directionCol[0];
                return;
            }

            row = directionRow[cd + 1];
            col = directionCol[cd + 1];
        }

        public static bool CheckMatrixValidation(int[,] arr, int x, int y)
        {
            int[] directionRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionCol = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (x + directionRow[i] >= arr.GetLength(0) || x + directionRow[i] < 0)
                {
                    directionRow[i] = 0;
                }

                if (y + directionCol[i] >= arr.GetLength(0) || y + directionCol[i] < 0)
                {
                    directionCol[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (arr[x + directionRow[i], y + directionCol[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static void FindCell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        x = i;
                        y = j;
                        {
                            return;
                        }
                    }
                }
            }
        }

       public static void Main()
        {
            int n = 3;
            int[,] matrix = new int[n, n];
            int step = n;
            int k = 1;
            int i = 0;
            int j = 0;
            int directionRow = 1;
            int directionCol = 1;

            while (true)
            {
                matrix[i, j] = k;

                if (!CheckMatrixValidation(matrix, i, j))
                {
                    break;
                }

                if (i + directionRow >= n || i + directionRow < 0
                    || j + directionCol >= n || j + directionCol < 0
                    || matrix[i + directionRow, j + directionCol] != 0)
                {
                    while (i + directionRow >= n || i + directionRow < 0
                        || j + directionCol >= n || j + directionCol < 0
                        || matrix[i + directionRow, j + directionCol] != 0)
                    {
                        ChangeMatrix(ref directionRow, ref directionCol);
                    }
                }

                i += directionRow;
                j += directionCol;
                k++;
            }

            for (int p = 0; p < n; p++)
            {
                for (int q = 0; q < n; q++)
                {
                    Console.Write("{0,3}", matrix[p, q]);
                }

                Console.WriteLine();
            }

            FindCell(matrix, out i, out j);

            if (i != 0 && j != 0)
            {
                directionRow = 1;
                directionCol = 1;

                while (true)
                {
                    matrix[i, j] = k;

                    if (!CheckMatrixValidation(matrix, i, j))
                    {
                        break;
                    }

                    if (i + directionRow >= n || i + directionRow < 0
                        || j + directionCol >= n || j + directionCol < 0
                        || matrix[i + directionRow, j + directionCol] != 0)
                    {
                        while (i + directionRow >= n || i + directionRow < 0
                            || j + directionCol >= n || j + directionCol < 0
                            || matrix[i + directionRow, j + directionCol] != 0)
                        {
                            ChangeMatrix(ref directionRow, ref directionCol);
                        }
                    }

                    i += directionRow;
                    j += directionCol;
                    k++;
                }
            }

            for (int pp = 0; pp < n; pp++)
            {
                for (int qq = 0; qq < n; qq++)
                {
                    Console.Write("{0,3}", matrix[pp, qq]);
                }

                Console.WriteLine();
            }
        }
    }
}
