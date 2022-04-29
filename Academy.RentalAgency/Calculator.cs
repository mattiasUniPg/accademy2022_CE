using System;

namespace TryCatchLegacy
{
    public class Calculator
    {
        public int Division(int firstNumber, int secondNumber)
        {
            var result = firstNumber / secondNumber;
            return result;
        }

        public int Add(int[] numbers)
        {
            var result = 0;
            for (var i = 0; i < 5; i++)
            {
                result += numbers[i];
            }
            return result;
        }
    }
}