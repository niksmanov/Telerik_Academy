using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] loops;
        static string[] words;
        static void Main()
        {
            Console.WriteLine("Write N: ");
            numberOfIterations = int.Parse(Console.ReadLine());
            Console.WriteLine("Write K: ");
            numberOfLoops = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a set of {0} words: ", numberOfIterations);
            words = Console.ReadLine().Split(new char[] { ',', ' ', '{', '}' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            loops = new int[numberOfLoops];
            GenerateVariations(0);
        }
        static void GenerateVariations(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintVariations();
                return;
            }
            for (int counter = 0; counter < numberOfIterations; counter++)
            {
                loops[currentLoop] = counter;
                GenerateVariations(currentLoop + 1);
            }
        }
        static void PrintVariations()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                var output = string.Empty;
                if (i == 0)
                {
                    output += "(" + words[loops[i]] + " ";
                }
                else if (i < numberOfLoops - 1)
                {
                    output += words[loops[i]] + " ";
                }
                else if (i == numberOfLoops - 1)
                {
                    output += words[loops[i]] + "), ";
                }
                Console.Write(output);
            }
        }
    }
}
