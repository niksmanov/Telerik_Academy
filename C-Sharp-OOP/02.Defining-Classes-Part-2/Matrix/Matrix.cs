using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix<T>
   where T : IComparable<T>
    {
        private int cols;
        private int rows;
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new T[rows, cols];
        }

        public int Rows
        {
            get { return this.rows; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Rows can't be negative");
                }
                this.rows = value;
            }
        }

        public int Cols
        {
            get { return this.cols; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Columns can't be negative");
                }
                this.cols = value;
            }
        }

        public T this[int row, int col]
        {
            get
            {
                CheckIndex(row, col);
                return this.matrix[row, col];
            }
            set
            {
                CheckIndex(row, col);
                this.matrix[row, col] = value;
            }
        }

        private void CheckIndex(int row, int col)
        {
            if (row < 0 || row > this.matrix.GetLength(0) ||
                col < 0 || col > this.matrix.GetLength(1))
            {
                throw new ArgumentOutOfRangeException("Invalid index.");
            }
        }

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            Matrix<T> resultMatrix = new Matrix<T>(first.Rows, first.Cols);

            if (first.Rows != second.Rows || first.Cols != second.Cols)
            {
                throw new Exception("To sum matrices they have to be with equal rows and columns");
            }

            for (int i = 0; i < resultMatrix.Rows; i++)
            {
                for (int j = 0; j < resultMatrix.Cols; j++)
                {
                    resultMatrix[i, j] = first[i, j] + (dynamic)second[i, j];

                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            Matrix<T> resultMatrix = new Matrix<T>(first.Rows, first.Cols);

            if (first.Rows != second.Rows || first.Cols != second.Cols)
            {
                throw new Exception("To sum matrices thay have to be with equal rows and columns");
            }

            for (int i = 0; i < resultMatrix.Rows; i++)
            {
                for (int j = 0; j < resultMatrix.Cols; j++)
                {
                    resultMatrix[i, j] = first[i, j] - (dynamic)second[i, j];

                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            Matrix<T> resultMatrix = new Matrix<T>(first.Rows, second.Cols);

            if (first.Rows != second.Cols)
            {
                throw new Exception("The rows of first matrix and the columns of the second matrix should be equal");
            }

            for (int i = 0; i < resultMatrix.Rows; i++)
            {
                for (int j = 0; j < resultMatrix.Cols; j++)
                {
                    dynamic tempSum = 0;
                    for (int k = 0; k < second.Rows; k++)
                    {
                        tempSum += (dynamic)first[i, k] * second[k, j];
                    }
                    resultMatrix[i, j] = tempSum;
                }
            }

            return resultMatrix;
        }

        private static bool IsAllZeroes(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] != (dynamic)0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return IsAllZeroes(matrix);
        }

        public static bool operator true(Matrix<T> matrix)
        {
            return IsAllZeroes(matrix);
        }

        public override string ToString()
        {
            string result = string.Empty;

            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    result += this.matrix[i, j].ToString().PadLeft(4);
                }
                result += "\n";
            }

            return result;
        }
    }
}
