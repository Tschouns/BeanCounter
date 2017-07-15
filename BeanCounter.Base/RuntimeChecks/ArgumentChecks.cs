namespace BeanCounter.Base.RuntimeChecks
{
    using System;

    /// <summary>
    /// Provides runtime checks for arguments, throws exceptions.
    /// </summary>
    public static class ArgumentChecks
    {
        /// <summary>
        /// Asserts that a specified argument is not <c>null</c>.
        /// </summary>
        public static void AssertNotNull(object argument, string argumentName)
        {
            if (argument == null)
            {
                throw new ArgumentNullException(argumentName);
            }
        }

        /// <summary>
        /// Asserts that a specified string argument is not <c>null</c> or empty.
        /// </summary>
        public static void AssertNotNullOrEmpty(string argument, string argumentName)
        {
            if (string.IsNullOrEmpty(argument))
            {
                throw new ArgumentNullException(argumentName);
            }
        }

        /// <summary>
        /// Asserts that a specified argument is not negative.
        /// </summary>
        public static void AssertNotNegative(int argument, string argumentName)
        {
            if (argument < 0)
            {
                throw new ArgumentNullException(argumentName);
            }
        }

        /// <summary>
        /// Asserts that a specified argument is not negative.
        /// </summary>
        public static void AssertNotNegative(decimal argument, string argumentName)
        {
            if (argument < 0)
            {
                throw new ArgumentNullException(argumentName);
            }
        }
    }
}
