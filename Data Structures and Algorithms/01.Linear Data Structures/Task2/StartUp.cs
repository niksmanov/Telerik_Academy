using System;
using System.Collections.Generic;

namespace Task2
{
    class StartUp
    {
        static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            for (int i = 0; i < count; i++)
            {
                var num = int.Parse(Console.ReadLine());
                stack.Push(num);
            }
            Console.WriteLine(string.Join(", ", stack.ToArray()));
        }
    }
}
