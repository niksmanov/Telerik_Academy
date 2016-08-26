using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class parseTags
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { '<', '>' }).ToArray();

        string openTag = "upcase";
        string closeTag = "/upcase";

        StringBuilder output = new StringBuilder();
        bool upperCase = false;

        foreach (var word in input)
        {
            if (word == openTag)
            {
                upperCase = true;
                continue;
            }

            else if (word == closeTag)
            {
                upperCase = false;
                continue;
            }

            else if (upperCase)
            {
                output.Append(word.ToUpper());
            }
            else
            {
                output.Append(word);
            }
        }
        Console.WriteLine(output);
    }
}
