using System;
using System.Numerics;

internal class Messages
{
    internal static void Main()
    {
        string firstNumber = Console.ReadLine().Replace("cad", "0").Replace("xoz", "1").Replace("nop", "2")
            .Replace("cyk", "3").Replace("min", "4").Replace("mar", "5").Replace("kon", "6")
            .Replace("iva", "7").Replace("ogi", "8").Replace("yan", "9");

        char sign = char.Parse(Console.ReadLine());

        string secondNumber = Console.ReadLine().Replace("cad", "0").Replace("xoz", "1").Replace("nop", "2")
            .Replace("cyk", "3").Replace("min", "4").Replace("mar", "5").Replace("kon", "6")
            .Replace("iva", "7").Replace("ogi", "8").Replace("yan", "9");

        BigInteger result = 0;

        if (sign == '-')
        {
            result = BigInteger.Parse(firstNumber) - BigInteger.Parse(secondNumber);
        }
        else if (sign == '+')
        {
            result = BigInteger.Parse(firstNumber) + BigInteger.Parse(secondNumber);
        }

        string numbers = result.ToString();

        foreach (var item in numbers)
        {
            Console.Write(item.ToString().Replace("0", "cad").Replace("1", "xoz").Replace("2", "nop")
               .Replace("3", "cyk").Replace("4", "min").Replace("5", "mar").Replace("6", "kon")
               .Replace("7", "iva").Replace("8", "ogi").Replace("9", "yan"));
        }
    }
}
