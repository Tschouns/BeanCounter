namespace BeanCounter.Calculator.Services.Constraints
{
    using BeanCounter.Calculator.Combinations;

    /// <summary>
    /// Validates a feature combination against a specific contraint.
    /// </summary>
    public interface IContraintValidator
    {
        /// <summary>
        /// Determines whether the specified combination is valid with regard to this contraint.
        /// </summary>
        bool IsValid(ICombination combination);
    }
}
