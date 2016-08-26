using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class enterNumbers
{
    static string checkNumbers(int[] numbers)
    {
        string output = string.Empty;
        try
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1] && numbers[i] > 1 && numbers[i] < 100)
                {
                    output = "1 < " + string.Join(" < ", numbers) + " < 100";
                }
                else
                {
                    output = "Exception";
                    break;
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Exception");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Exception");
        }
        return output;
    }

    static void Main()
    {
        int[] numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(checkNumbers(numbers));
    }
}
