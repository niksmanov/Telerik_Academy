using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] loops;
        static string[] words;
        static List<string> memoList = new List<string>();
        static void Main()
        {
            Console.WriteLine("Write a set of words: ");
            words = Console.ReadLine().Split(new char[] { ',', ' ', '{', '}' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            numberOfIterations = words.Length;
            Console.WriteLine("Write K: ");
            numberOfLoops = int.Parse(Console.ReadLine());
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
            if (!memoList.Contains(words[loops[0]]))
            {
                memoList.Add(words[loops[0]]);
            }


            for (int i = 0; i < numberOfLoops; i++)
            {
                var output = string.Empty;
                if (!memoList.Contains(words[loops[numberOfLoops - 1]]))
                {
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
                }
                Console.Write(output);
            }
        }
    }
}
