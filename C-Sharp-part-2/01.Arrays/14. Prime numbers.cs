using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class primeNumbers
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());

        for (long i = num; i >= 0; i--)
        {
            bool isPrime = true;
         
            for (long j = 2; j < i; j++) 
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}



