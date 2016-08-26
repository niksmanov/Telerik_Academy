using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class correctBrackets
{
    static void Main()
    {
        string input = Console.ReadLine();
        int openBrackets = 0;
        int closeBracets = 0;

        foreach (var item in input)
        {
            if (item == '(')
            {
                openBrackets++;
            }
            else if (item == ')')
            {
                closeBracets++;
            }
        }
        if (openBrackets == closeBracets)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
}
