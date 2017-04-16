using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static List<int> permutations = new List<int>();

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
            string number = string.Join("", arr);
            permutations.Add(int.Parse(number));
        }

        static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }

        static int Factor(int number)
        {
            int count = 0;
            //List<int> factors = new List<int>();
            int max = (int)Math.Sqrt(number);
            for (int factor = 1; factor <= max; ++factor)
            {
                if (number % factor == 0)
                {
                    count++;
                    //factors.Add(factor);
                    if (factor != number / factor)
                    {
                        count++;
                        //factors.Add(number / factor);
                    }
                }
            }
            //return factors;
            return count;
        }
        static void Main()
        {

            var arrNumber = int.Parse(Console.ReadLine());

            var arr = new int[arrNumber];

            for (int i = 0; i < arrNumber; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
            PermuteRep(arr, 0, arr.Length);

            var factorsCount = new List<int>();

            foreach (var number in permutations)
            {
                factorsCount.Add(Factor(number));
            }

            var min = factorsCount.Min();
            var minIndex = factorsCount.IndexOf(min);
            Console.WriteLine(permutations[minIndex]);
        }
    }
}
