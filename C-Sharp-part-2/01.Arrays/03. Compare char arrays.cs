using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class compareCharArrays
{
    static void Main()
    {


        string first = Console.ReadLine();
        string second = Console.ReadLine();

        if (first.CompareTo(second) == 0)
        {
            Console.WriteLine("=");
        }
        else if (first.CompareTo(second) == 1)
        {
            Console.WriteLine(">");
        }
        else
        {
            Console.WriteLine("<");
        }
        
        
    }


}

