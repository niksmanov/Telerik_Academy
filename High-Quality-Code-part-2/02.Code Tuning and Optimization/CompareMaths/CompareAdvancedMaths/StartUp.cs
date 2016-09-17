using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareAdvancedMaths
{
    internal class StartUp
    {
        internal static void Main()
        {
            Console.WriteLine("Float test");
            float firstNumber = 100f;
            var firstCompare = new CompareAdvancedMaths();
            firstCompare.SquareRoot(firstNumber);
            firstCompare.NaturalLogarithm(firstNumber);
            firstCompare.Sinus(firstNumber);

            Console.WriteLine("Double test");
            double secondNumber = 100d;
            var secondCompare = new CompareAdvancedMaths();
            secondCompare.SquareRoot(secondNumber);
            secondCompare.NaturalLogarithm(secondNumber);
            secondCompare.Sinus(secondNumber);

            Console.WriteLine("Decimal test");
            var thirdNumber = 100d;
            var thirdCompare = new CompareAdvancedMaths();
            thirdCompare.SquareRoot(thirdNumber);
            thirdCompare.NaturalLogarithm(thirdNumber);
            thirdCompare.Sinus(thirdNumber);
        }
    }
}
