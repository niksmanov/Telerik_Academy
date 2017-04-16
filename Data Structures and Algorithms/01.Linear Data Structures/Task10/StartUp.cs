using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class StartUp
    {
        static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int finishNumber = int.Parse(Console.ReadLine());
            int operations = 0;
            var output = new Queue<int>();

            //Posible operations:
            //1. N = N+1
            //2. N = N+2
            //3. N = N*2

            while (startNumber < finishNumber && startNumber != finishNumber)
            {
                if (finishNumber % startNumber == 0)        //startNumber * 2 <= finishNumber 
                {                                           //less effective in most of the cases
                    startNumber *= 2;                    
                    output.Enqueue(startNumber);
                    operations++;
                }
                else if ((finishNumber / 2) - startNumber >= 2)
                {
                    startNumber = (startNumber + 2);
                    output.Enqueue(startNumber);
                    startNumber *= 2;
                    output.Enqueue(startNumber);
                    operations += 2;
                }
                else if ((finishNumber / 2) - startNumber >= 1)
                {
                    startNumber = (startNumber + 1);
                    output.Enqueue(startNumber);
                    startNumber *= 2;
                    output.Enqueue(startNumber);
                    operations += 2;
                }
                else if ((finishNumber - startNumber) % 2 == 0)
                {
                    startNumber += 2;                    
                    output.Enqueue(startNumber);
                    operations++;
                }
                else if ((finishNumber - startNumber) % 2 == 1)
                {
                    startNumber += 1;                    
                    output.Enqueue(startNumber);
                    operations++;
                }
            }

            Console.WriteLine($"Final number: {finishNumber}" +
            Environment.NewLine + $"Number of operations: {operations}" +
            Environment.NewLine + $"Operations: {string.Join(" -> ", output)}");
        }
    }
}
