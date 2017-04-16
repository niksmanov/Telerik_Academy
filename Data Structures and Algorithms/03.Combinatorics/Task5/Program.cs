using System;

namespace Task2
{
    class Program
    {
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] loops;
        static int count;

        static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            numberOfIterations = int.Parse(input[0]);
            numberOfLoops = int.Parse(input[1]);
            loops = new int[numberOfLoops];
            CombinationsWithDuplicates(0);

            Console.WriteLine(count);
        }
        static void CombinationsWithDuplicates(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintCombinationsWithDuplicates();
                return;
            }
            for (int counter = 0; counter < numberOfIterations; counter++)
            {
                loops[currentLoop] = counter;
                CombinationsWithDuplicates(currentLoop + 1);
            }
        }
        static void PrintCombinationsWithDuplicates()
        {
            var number = 0;
            if (numberOfLoops == 2)
            {
                number = 1;
            }
            else if (numberOfLoops > 2)
            {
                number = 2;
            }
            else if (numberOfLoops == 1)
            {
                count = numberOfIterations;
            }

            for (int i = 0; i < numberOfLoops - number; i++)
            {
                if (numberOfLoops == 2 && loops[i] > loops[i + 1])
                {
                    count++;
                }
                if (numberOfLoops > 2 && loops[i] > loops[i + 1] && loops[i + 1] < loops[i + 2])
                {
                    count++;
                }
            }
        }
    }
}