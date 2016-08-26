using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class hello
{
    static void PrintName(string input)
    {
        Console.WriteLine("Hello, {0}!", input);
    }

    static void Main()
    {
        string name = Console.ReadLine();
       PrintName(name);
    }
}
