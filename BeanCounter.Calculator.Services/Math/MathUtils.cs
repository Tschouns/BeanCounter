namespace BeanCounter.Calculator.Services.Math
{
    using BeanCounter.Base.RuntimeChecks;
    using System;

    /// <summary>
    /// Provides mathematical utilities.
    /// </summary>
    public static class MathUtils
    {
        /// <summary>
        /// Calculates the factorial number for the specified number.
        /// </summary>
        public static ulong Factorial(int number)
        {
            ArgumentChecks.AssertNotNegative(number, nameof(number));

            return CalculateFactorialInternal(Convert.ToUInt64(number));
        }

        private static ulong CalculateFactorialInternal(ulong number)
        {
            if (number <= 1)
            {
                return 1;
            }

            return number * CalculateFactorialInternal(number - 1);
        }
    }
}
