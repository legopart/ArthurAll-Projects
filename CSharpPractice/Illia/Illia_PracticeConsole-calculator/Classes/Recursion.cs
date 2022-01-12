using System;

namespace ConsoleCalculator.Classes
{
    public static class Recursion
    {
        public static int CalculateFactorial(int seedValue)
        {

            if (seedValue < 0)
            {
                throw new ArgumentException("Factorial for negative numbers is impossible");
            }

            if (seedValue == 0)
            {
                return 1;
            }

            if (seedValue == 1)
            {
                return seedValue;
            }
            else
            {
                return seedValue * CalculateFactorial(--seedValue);
            }
        }

        public static string GetNextNumber(string input, int positionFromEnd = 0)
        {
            if(positionFromEnd >= input.Length)
            {
                return "".PadLeft(input.Length, '0');
            }

            //int digit = int.Parse(input.Substring(input.Length - 1 - positionFromEnd, 1));
            int digit = int.Parse(input[input.Length - 1 - positionFromEnd].ToString());
            if (digit == 9)
            {
                return GetNextNumber(input, ++positionFromEnd);
            }
            else
            {
                return input.Substring(0, input.Length - 1 - positionFromEnd) + (++digit).ToString().PadRight(positionFromEnd + 1, '0');
            }
        }
    }
}
