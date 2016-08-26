using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class englishDigit
{
    static int NeededNumber(string characters)
    {
        int lastNumber = 0;
        for (int i = 0; i < characters.Length; i++)
        {
            lastNumber = characters[characters.Length - 1] - '0';
        }
        return lastNumber;
    }
    static void NumberAsWord(int number)
    {
        switch (number)
        {
            case 0: Console.WriteLine("zero"); break;
            case 1: Console.WriteLine("one"); break;
            case 2: Console.WriteLine("two"); break;
            case 3: Console.WriteLine("three"); break;
            case 4: Console.WriteLine("four"); break;
            case 5: Console.WriteLine("five"); break;
            case 6: Console.WriteLine("six"); break;
            case 7: Console.WriteLine("seven"); break;
            case 8: Console.WriteLine("eight"); break;
            case 9: Console.WriteLine("nine"); break;
            default: Console.WriteLine("Not a valid entry!"); break;
        }
    }

    static void Main()
    {
        string number = Console.ReadLine();
        char[] array = number.ToCharArray();

        NumberAsWord(NeededNumber(number));
    }
}
