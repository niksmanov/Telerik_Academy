using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class extractSentences
{
    static void Main()
    {
        string word = Console.ReadLine();
        string[] text = Console.ReadLine().Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> output = new List<string>();

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Contains(" " + word))
            {
                output.Add(text[i].Trim());
            }
        }
        
        Console.WriteLine(string.Join(". ", output) + ".");
    }
}