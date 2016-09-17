using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSimpleMaths
{
    internal class StartUp
    {
        internal static void Main()
        {
            Console.WriteLine("Integer test");
            int firstNumber = 100;
            var firstCompare = new CompareSimpleMaths();
            firstCompare.Add(firstNumber);
            firstCompare.Subtract(firstNumber);
            firstCompare.Multiply(firstNumber);
            firstCompare.Divide(firstNumber);

            Console.WriteLine("Long test");
            long secondNumber = 100L;
            var secondCompare = new CompareSimpleMaths();
            secondCompare.Add(secondNumber);
            secondCompare.Subtract(secondNumber);
            secondCompare.Multiply(secondNumber);
            secondCompare.Divide(secondNumber);

            Console.WriteLine("Float test");
            float thirdNumber = 100f;
            var thirdCompare = new CompareSimpleMaths();
            thirdCompare.Add(thirdNumber);
            thirdCompare.Subtract(thirdNumber);
            thirdCompare.Multiply(thirdNumber);
            thirdCompare.Divide(thirdNumber);

            Console.WriteLine("Double test");
            double forthNumber = 100d;
            var forthCompare = new CompareSimpleMaths();
            forthCompare.Add(forthNumber);
            forthCompare.Subtract(forthNumber);
            forthCompare.Multiply(forthNumber);
            forthCompare.Divide(forthNumber);

            Console.WriteLine("Decimal test");
            decimal fifthNumber = 100m;
            var fifthCompare = new CompareSimpleMaths();
            fifthCompare.Add(fifthNumber);
            fifthCompare.Subtract(fifthNumber);
            fifthCompare.Multiply(1m);
            fifthCompare.Divide(fifthNumber);
        }
    }
}
