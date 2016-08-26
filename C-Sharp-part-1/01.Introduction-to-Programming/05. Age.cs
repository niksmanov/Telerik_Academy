using System;
using System.Globalization;

class age
{
    static void Main()
    {
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        long result = DateTime.Today.Subtract(birthday).Ticks;
        Console.WriteLine(new DateTime(result).Year - 1);
        Console.WriteLine(new DateTime(result).AddYears(10).Year - 1);
    }
}
