using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class squareRoot
{
    static void Main()
    {
        try
        {
            double number = double.Parse(Console.ReadLine());
            double sqrt = Math.Sqrt(number);

            if (sqrt.ToString() == "NaN")
            {
                Console.WriteLine("Invalid number"); 
            }
            else
            {
                Console.WriteLine("{0:F3}", sqrt);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");            
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
        
    }
}
