using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class stringLength
{
    static void Main()
    {
        string input = Console.ReadLine();
        string output = string.Empty;

        if (input.Length < 20)
        {
            output = input + new string('*', 20 - input.Length);
        }
        else
        {
            output = input;
        }
        Console.WriteLine(output);
    }
}
