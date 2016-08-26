using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class reverseString
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(string.Join("", input.Reverse()));
        }
    }
