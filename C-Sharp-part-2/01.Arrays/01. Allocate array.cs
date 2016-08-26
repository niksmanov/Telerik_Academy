using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class allocateArray
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        int[] array = new int[numbers];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;  
         Console.WriteLine(array[i]);
        }


    }
}

