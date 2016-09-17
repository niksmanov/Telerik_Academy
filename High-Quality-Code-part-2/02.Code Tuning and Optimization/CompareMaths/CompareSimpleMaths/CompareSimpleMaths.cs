using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSimpleMaths
{
    internal class CompareSimpleMaths
    {
        public const int MaxLoopCount = 1000000;
        public const long CalculationsNumber = 1000000000;

        internal void Add(dynamic number)
        {
            var sw = Stopwatch.StartNew();
            var result = 0;

            for (int i = 0; i < MaxLoopCount; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result += number;
                }
            }
            sw.Stop();
            Console.WriteLine("The elapsed add time is: " + sw.Elapsed);
        }

        internal void Subtract(dynamic number)
        {
            var sw = Stopwatch.StartNew();
            var result = CalculationsNumber;

            for (int i = 0; i < MaxLoopCount; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result -= number;
                }
            }
            sw.Stop();
            Console.WriteLine("The elapsed subtract time is: " + sw.Elapsed);
        }

        internal void Multiply(dynamic number)
        {
            var sw = Stopwatch.StartNew();
            var result = 1;

            for (int i = 0; i < MaxLoopCount; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result *= number;
                }
            }
            sw.Stop();
            Console.WriteLine("The elapsed multiply time is: " + sw.Elapsed);
        }

        internal void Divide(dynamic number)
        {
            var sw = Stopwatch.StartNew();
            var result = CalculationsNumber;

            for (int i = 0; i < MaxLoopCount; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result /= number;
                }
            }
            sw.Stop();
            Console.WriteLine("The elapsed divide time is: " + sw.Elapsed);
        }
    }
}
