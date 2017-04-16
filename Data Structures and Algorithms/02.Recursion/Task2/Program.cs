using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
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
            CombinationsWithDuplicates(0);
        }
        static void CombinationsWithDuplicates(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintCombinationsWithDuplicates();
                return;
            }
            for (int counter = 1; counter <= numberOfIterations; counter++)
            {
                loops[currentLoop] = counter;
                CombinationsWithDuplicates(currentLoop + 1);
            }
        }
        static void PrintCombinationsWithDuplicates()
        {
            if (!memoList.Contains(loops[0]))
            {
                memoList.Add(loops[0]);
            }

            for (int i = 0; i < numberOfLoops; i++)
            {
                var output = string.Empty;
                if (!memoList.Contains(loops[numberOfLoops - 1]) || loops[0] == loops[numberOfLoops - 1])
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