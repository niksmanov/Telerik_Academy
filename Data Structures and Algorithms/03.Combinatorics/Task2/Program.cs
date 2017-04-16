using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main() //DOESN'T WORK CORRECTLY!!!
        {
            int askedRabbits = int.Parse(Console.ReadLine());

            var rabbitsCount = new List<int>(askedRabbits);

            var memoList = new List<int>();

            for (int i = 0; i < askedRabbits; i++)
            {
                rabbitsCount.Add(int.Parse(Console.ReadLine()));
            }

            long count = 0;

            for (int i = 0; i < rabbitsCount.Count; i++)
            {
                for (int j = i + 1; j < rabbitsCount.Count; j++)
                {
                    if (rabbitsCount[i] == rabbitsCount[j])
                    {
                        count += rabbitsCount[i] + 1;
                        rabbitsCount.RemoveAt(j);
                        memoList.Add(rabbitsCount[i]);            
                    }
                    else if (rabbitsCount[i] != rabbitsCount[j] && 
                        !memoList.Contains(rabbitsCount[i]))
                    {
                        count += rabbitsCount[i] + 1;
                    }
                    break;
                }
            }

            if (rabbitsCount.Count == 1)
            {
                count = 1;
            }

            Console.WriteLine(count);
        }
    }
}