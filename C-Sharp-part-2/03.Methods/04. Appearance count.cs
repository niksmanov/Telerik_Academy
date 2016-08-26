using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class appearanceCount
{
    static int CountOfNumberX(int[] numbers, int X)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == X)
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        int arr = int.Parse(Console.ReadLine());
        int[] numbers = new int[arr];
        string[] input = Console.ReadLine().Split(' ');
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }
        int X = int.Parse(Console.ReadLine());

        Console.WriteLine(CountOfNumberX(numbers, X));
    }
}
