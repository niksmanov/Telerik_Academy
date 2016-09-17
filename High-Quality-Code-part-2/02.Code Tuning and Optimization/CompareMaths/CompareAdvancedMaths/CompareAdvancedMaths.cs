using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareAdvancedMaths
{
    internal class CompareAdvancedMaths
    {
        public const int MaxLoopCount = 1000000;

        internal void SquareRoot(dynamic number)
        {
            var sw = Stopwatch.StartNew();

            for (int i = 0; i < MaxLoopCount; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Math.Sqrt(number);
                }
            }
            sw.Stop();
            Console.WriteLine("The elapsed square root time is: " + sw.Elapsed);
        }

        internal void NaturalLogarithm(dynamic number)
        {
            var sw = Stopwatch.StartNew();

            for (int i = 0; i < MaxLoopCount; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Math.Log(number);
                }
            }
            sw.Stop();
            Console.WriteLine("The elapsed natural logarithm time is: " + sw.Elapsed);
        }

        internal void Sinus(dynamic number)
        {
            var sw = Stopwatch.StartNew();

            for (int i = 0; i < MaxLoopCount; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Math.Sin(number);
                }
            }
            sw.Stop();
            Console.WriteLine("The elapsed sinus time is: " + sw.Elapsed);
        }

    }
}
