using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    internal class StartUp
    {
        internal static void Main()
        {
            var firstPerson = new Person("Pesho", 12);
            var secondPerson = new Person("Gosho", null);

            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
        }
    }
}
