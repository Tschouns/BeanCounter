namespace BeanCounter.Calculator.Services.Combinations
{
    /// <summary>
    /// Provides random numbers.
    /// </summary>
    public interface IRandomizer
    {
        /// <summary>
        /// Gets a random non-negative number.
        /// </summary>
        int GetRandomNumber();
    }
}
