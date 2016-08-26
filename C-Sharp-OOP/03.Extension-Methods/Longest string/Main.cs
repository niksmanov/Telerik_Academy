using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_string
{
    class Program
    {
        static void Main()
        {
            var listOfStrings = new List<string>() { "1", "12", "123", "1234", "1234567" };
            string biggestLenght = listOfStrings.FirstOrDefault(x => x.Length == listOfStrings.Max(y => y.Length));
            Console.WriteLine(biggestLenght);
        }
    }
}
