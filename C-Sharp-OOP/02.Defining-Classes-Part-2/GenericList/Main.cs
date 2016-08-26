using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main()
        {
            GenericList<int> firstList = new GenericList<int>();
            Console.WriteLine(firstList);


            firstList.Add(31);
            Console.WriteLine(firstList);


            firstList.AddAtPosition(52, 0);
            Console.WriteLine(firstList);


            int findThis = 31;
            int firstOccur = firstList.FindFirst(findThis);
            Console.WriteLine("Element {0} is with {1} index", findThis, firstOccur);


            firstList.Remove(1);
            Console.WriteLine(firstList);


            firstList.Clear();
            Console.WriteLine(firstList);

            GenericList<int> secondList = new GenericList<int>();

            for (int i = 0; i < 2; i++)
            {
                secondList.Add(0);
                secondList.Add(10);
                secondList.Add(15);
                secondList.Add(5);
                secondList.Add(3);
                secondList.Add(-1);
                secondList.Add(100);
            }



            Console.WriteLine(secondList);

            Console.WriteLine("Min is {0}", secondList.Min());
            Console.WriteLine("Max is {0}", secondList.Max());

        }
    }
}
