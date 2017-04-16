using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = 50;

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);

            var output = new StringBuilder();

            for (int i = 0; i < p; i++)
            {             
                int current = queue.Dequeue();
                output.Append(current + " ");
                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current + 1);
                queue.Enqueue(current + 2);
            }

            Console.WriteLine(output);
        }
    }
}
