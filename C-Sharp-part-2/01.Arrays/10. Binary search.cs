using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class binarySearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);

        int x = int.Parse(Console.ReadLine());
        int index = Array.BinarySearch(numbers, x);
        if (index >= 0)
        {
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine("-1");
        }

    }
}
