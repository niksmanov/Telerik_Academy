using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class frequentNumber
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
        int counter = 1;
        int maxCounter = 1;
        int number = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                counter++;
            }
            else
            {
                counter = 1;
            }
            if (counter > maxCounter)
            {
                maxCounter = counter;
                number = numbers[i];
            }
        }


        Console.WriteLine("{0} ({1} times)", number, maxCounter);
    }
}
