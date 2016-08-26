using System;

class intDoubleString
{
    static void Main()
    {
        string type = Console.ReadLine();

        switch (type)
        {
            case "integer": int a = int.Parse(Console.ReadLine());
                Console.WriteLine(a + 1); break;
            case "real": double b = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", b + 1); break;
            case "text": string text = Console.ReadLine();
                Console.WriteLine(text + "*"); break;
            default: Console.WriteLine("Not a valid entry"); break;

        }
    }
}

