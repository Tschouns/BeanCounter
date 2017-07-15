namespace BeanCounter.Calculator.Services.Combinations
{
    using BeanCounter.Calculator.Input;
    using System.Collections.Generic;

    /// <summary>
    /// Generates random combinations.
    /// </summary>
    public interface IRandomCombinationGenerator
    {
        /// <summary>
        /// Generates a random combination based on the specified features.
        /// </summary>
        Combination GenerateCombination(IEnumerable<Feature> features);
    }
}
