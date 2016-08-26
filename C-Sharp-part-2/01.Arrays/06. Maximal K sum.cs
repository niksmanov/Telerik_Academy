using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class maxKsum
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            int K = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int maxSum = 0;

            Array.Sort(numbers);
            Array.Reverse(numbers);

            for (int i = 0; i < K; i++)
            {
                maxSum += numbers[i]; 
            }

            Console.WriteLine(maxSum);
        }
    }

