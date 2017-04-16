using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class StartUp
    {
        static void Main()
        {
            var sequence = Console.ReadLine().Split(new char[] { ',', ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            //var sequence = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            for (int i = 0; i < sequence.Count; i++)
            {
                var counter = 0;
                for (int j = i; j < sequence.Count; j++)
                {
                    if (sequence[i] == sequence[j])
                    {
                        counter++;
                        if (counter % 2 == 1)
                        {
                            sequence.RemoveAt(i);
                        }
                    }
                }
            }

            Console.WriteLine("Numbers that occur even number of times: " + string.Join(", ", sequence));
        }
    }
}
