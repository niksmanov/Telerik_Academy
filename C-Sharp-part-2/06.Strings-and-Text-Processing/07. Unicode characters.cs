using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class unicodeCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();

            foreach (var item in input)
            {
                Console.Write("\\u{0:X4}", (int)item);
            }
        }
    }
