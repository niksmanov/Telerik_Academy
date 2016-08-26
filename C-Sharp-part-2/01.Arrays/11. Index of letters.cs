using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class indexOfLetters
{
    static void Main()
    {

        string input = Console.ReadLine();
       
        char[] letters = new char[26];

        int index = 0;
        for (char i = 'a'; i <= 'z'; i++, index++)
        {
            letters[index] = i;
        }

        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];
            Console.WriteLine(Array.IndexOf(letters, currentChar));
        }

    }
}
