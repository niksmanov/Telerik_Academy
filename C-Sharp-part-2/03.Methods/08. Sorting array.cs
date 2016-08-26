using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class sortArray
{
    static int[] ReverseNumbers(int[] numbers)
    {
        Array.Sort(numbers);
        return numbers;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        string[] numbers = Console.ReadLine().Split(' ');

        for (int i = 0; i < numbers.Length; i++)
        {
            arr[i] = int.Parse(numbers[i]);
        }

        Console.WriteLine(string.Join(" ", ReverseNumbers(arr)));

    }
}

