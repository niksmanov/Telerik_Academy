﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main()
        {
            var firstMatrix = new Matrix<int>(3, 3);
            if (firstMatrix != new Matrix<int>(3, 3))
            {
                FillSum(firstMatrix);
            }

            Console.WriteLine(firstMatrix);
            if (firstMatrix)
            {
                Console.WriteLine("First matrix is no longer empty!");
            }

            var addMatrix = new Matrix<int>(3, 3);
            FillOne(addMatrix);


            Console.WriteLine("AddMatrix:");
            Console.WriteLine(addMatrix);

            var addResult = firstMatrix + addMatrix;
            Console.WriteLine();
            Console.WriteLine("Result of add:");
            Console.WriteLine(addResult);

            var secondMatrix = new Matrix<int>(3, 5);
            if (secondMatrix != new Matrix<int>(3, 5))
            {
                FillMulty(secondMatrix);
            }

            Console.WriteLine("Second matrix:");
            Console.WriteLine(secondMatrix);

            var multyResult = firstMatrix * secondMatrix;

            Console.WriteLine("Multiplication result:");
            Console.WriteLine(multyResult);
        }

        public static void FillSum(Matrix<int> curentMatrix)
        {
            for (int i = 0; i < curentMatrix.Rows; i++)
            {
                for (int j = 0; j < curentMatrix.Cols; j++)
                {
                    curentMatrix[i, j] = i + j;
                }
            }
        }

        public static void FillOne(Matrix<int> curentMatrix)
        {
            for (int i = 0; i < curentMatrix.Rows; i++)
            {
                for (int j = 0; j < curentMatrix.Cols; j++)
                {
                    curentMatrix[i, j] = 1;
                }
            }
        }

        public static void FillMulty(Matrix<int> curentMatrix)
        {
            for (int i = 0; i < curentMatrix.Rows; i++)
            {
                for (int j = 0; j < curentMatrix.Cols; j++)
                {
                    curentMatrix[i, j] = i * j;
                }
            }

        }
    }
}
