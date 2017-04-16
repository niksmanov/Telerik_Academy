using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static int numberOfIterations;
        static int[] loops;
        static List<int> memoList = new List<int>();
        static void Main()
        {
            Console.WriteLine("Write a number: ");
            numberOfIterations = int.Parse(Console.ReadLine());
            loops = new int[numberOfIterations];
            GeneratePermutations(0);
        }
        static void GeneratePermutations(int currentLoop)
        {
            if (currentLoop == numberOfIterations)
            {
                PrintPermutations();
                return;
            }
            for (int counter = 1; counter <= numberOfIterations; counter++)
            {
                loops[currentLoop] = counter;
                GeneratePermutations(currentLoop + 1);
            }
        }
        static void PrintPermutations()
        {
            var output = "{ ";
            var count = 0;
            var number = 0;
            
            for (int i = 0; i < numberOfIterations; i++)
            {      
                if (number != loops[i] && !memoList.Contains(loops[i]))
                {
                    number = loops[i];
                    memoList.Add(number);
                    count++;
                    output += number + " ";
                }
                
                if (count == numberOfIterations)
                {
                    output += "}, ";
                    Console.Write(output);
                }
            }
            memoList.Clear();
        }
    }
}
