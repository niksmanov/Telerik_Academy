using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] loops;
        static List<int> memoList = new List<int>();
        static void Main()
        {
            Console.WriteLine("Write N: ");
            numberOfIterations = int.Parse(Console.ReadLine());
            Console.WriteLine("Write K: ");
            numberOfLoops = int.Parse(Console.ReadLine());
            loops = new int[numberOfLoops];
            CombinationsWithoutDuplicates(0);
        }
        static void CombinationsWithoutDuplicates(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintCombinationsWithoutDuplicates();
                return;
            }
            for (int counter = 1; counter <= numberOfIterations; counter++)
            {
                loops[currentLoop] = counter;
                CombinationsWithoutDuplicates(currentLoop + 1);
            }
        }
        static void PrintCombinationsWithoutDuplicates()
        {
            if (!memoList.Contains(loops[0]))
            {
                memoList.Add(loops[0]);
            }

            for (int i = 0; i < numberOfLoops; i++)
            {
                var output = string.Empty;
                if (!memoList.Contains(loops[numberOfLoops - 1]))
                {
                    if (i == 0)
                    {
                        output += "(" + loops[i] + " ";
                    }
                    else if (i < numberOfLoops - 1)
                    {
                        output += loops[i] + " ";
                    }
                    else if (i == numberOfLoops - 1)
                    {
                        output += loops[i] + "), ";
                    }
                }
                Console.Write(output);
            }
        }
    }
}
