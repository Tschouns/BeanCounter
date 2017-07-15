using BeanCounter.Calculator.Input;
using System.Collections.Generic;

namespace BeanCounter.Calculator.Services.Combinations
{
    /// <summary>
    /// Generates combinations.
    /// </summary>
    public interface ICombinationGenerator
    {
        /// <summary>
        /// Generates a new combination based on the specified features.
        /// </summary>
        Combination GenerateCombination(IEnumerable<Feature> features);
    }
}
