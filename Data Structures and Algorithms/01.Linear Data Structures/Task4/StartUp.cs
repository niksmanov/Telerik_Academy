using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    class StartUp
    {
        static List<int> FindLongestSubSequence(List<int> sequence)
        {
            var currentSeq = new List<int>();
            var maxSeq = new List<int>();

            for (int i = 0; i < sequence.Count - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    currentSeq.Add(sequence[i + 1]);
                    if (i == sequence.Count - 2 && sequence[i] == sequence[sequence.Count - 1] && maxSeq.Count < currentSeq.Count + 1)
                    {
                        currentSeq.Add(sequence[i + 1]);
                        maxSeq.Clear();
                        maxSeq.AddRange(currentSeq);
                        currentSeq.Clear();
                    }
                }
                else if (i > 0 && sequence[i - 1] == sequence[i])
                {
                    currentSeq.Add(sequence[i]);
                }
                if (sequence[i] != sequence[i + 1] && maxSeq.Count < currentSeq.Count)
                {
                    maxSeq.Clear();
                    maxSeq.AddRange(currentSeq);
                    currentSeq.Clear();
                }
                else if (sequence[i] != sequence[i + 1])
                {
                    currentSeq.Clear();
                }
            }
            return maxSeq;
        }
        static void Main()
        {
            var sequence = Console.ReadLine().Split(new char[] { ',', ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Console.WriteLine("Longest subsequence is: " + string.Join(", ", FindLongestSubSequence(sequence)));

        }
    }
}
