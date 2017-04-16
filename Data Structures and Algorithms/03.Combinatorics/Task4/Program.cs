using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    class Program
    {
        static List<string> permutations = new List<string>();

        static void PermuteRep(int[] arr, int start, int n)
        {
            GenerateResult(arr);

            for (int left = n - 2; left >= start; left--)
            {
                for (int right = left + 1; right < n; right++)
                {
                    if (arr[left] != arr[right])
                    {
                        Swap(ref arr[left], ref arr[right]);
                        PermuteRep(arr, left + 1, n);
                    }
                }

                var firstElement = arr[left];
                for (int i = left; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[n - 1] = firstElement;
            }
        }

        static void GenerateResult<T>(T[] arr)
        {
            var builder = new StringBuilder();
            builder.Append(arr);
            permutations.Add(builder.ToString());
        }

        static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }

        static void Main()
        {

            var input = Console.ReadLine();

            var arr = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = input[i] - 'A';
            }

            Array.Sort(arr);
            PermuteRep(arr, 0, arr.Length);
            Console.WriteLine(permutations.Count());
        }
    }
}