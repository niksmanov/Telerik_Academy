using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class reverseNumbers
{
    static char[] ReverseNumbers(char[] numbers)
    {
        Array.Reverse(numbers);
        return numbers;
    }

    static void Main()
    {
        string input = Console.ReadLine();
        char[] arr = input.ToCharArray();
        Console.WriteLine(ReverseNumbers(arr));

    }
}
