namespace ControlFlowConditionalStatementsLoops.Refactoring
{
    using System;

    internal class RefactorLoop
    {
        private const uint Value = 100;

        internal static void LoopRefactor(uint[] numbersArray, uint expectedValue)
        {
            bool isValueFound = false;

            for (uint i = 0; i < Value; i++)
            {
                IsExpectedValueFound(i, expectedValue, numbersArray[i]);
                if (isValueFound == true)
                {
                    Console.WriteLine("Value Found");
                    break;
                }
            }
        }

        internal static bool IsExpectedValueFound(uint index, uint expectedValue, uint arrayIndex)
        {
            bool result = false;
            if (index % 10 == 0 && expectedValue == arrayIndex)
            {
                result = true;
            }

            return result;
        }
    }
}
