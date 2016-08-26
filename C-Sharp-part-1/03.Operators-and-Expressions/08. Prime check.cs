using System;

class primeCheck
{
    static void Main()
    {
      
        int num = int.Parse(Console.ReadLine());
        if (num <= 1)
        {
            Console.WriteLine("false");
        }
        else if (num > 1 && num <= 100) // Checks numbers in interval
        {
            if (num == 2 || num == 3 || num == 5 || num == 7) // Checks numbers 2, 3, 5, 7
            {
                Console.WriteLine("true");
            }
            else
            {
                if (num % 2 != 0 && num % 3 != 0 && num % 5 != 0 && num % 7 != 0) // Checks division with reminder
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}

