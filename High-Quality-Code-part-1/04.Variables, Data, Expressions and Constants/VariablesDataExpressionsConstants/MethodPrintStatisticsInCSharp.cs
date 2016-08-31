namespace VariablesDataExpressionsConstants
{
    internal class MethodPrintStatisticsInCSharp
    {
        public static double FindMaxValue(double[] numbersArray, int numbersCount)
        {
            double maxValue = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                if (numbersArray[i] > maxValue)
                {
                    maxValue = numbersArray[i];
                }
            }

            return maxValue;
        }

        public static double FindMinValue(double[] numbersArray, int numbersCount)
        {
            double minValue = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                if (numbersArray[i] < minValue)
                {
                    minValue = numbersArray[i];
                }
            }

            return minValue;
        }

        public static double AverageValues(double[] numbersArray, int numbersCount)
        {
            double sum = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                sum += numbersArray[i];
            }

            double average = sum / numbersCount;

            return average;
        }
    }
}
