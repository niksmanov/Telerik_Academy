using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class compareArrays
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            var firstArr = new int[size];
            var secondArr = new int[size];

            for (int i = 0; i < firstArr.Length; i++)
            {
                firstArr[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < secondArr.Length; j++)
            {
                secondArr[j] = int.Parse(Console.ReadLine());
            }

            bool equal = true;
            for (int i = 0; i < size; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    equal = false;
                    break;
                }
          
            }
            Console.WriteLine(equal ? "Equal" : "Not equal");

        }
    }

