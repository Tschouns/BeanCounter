namespace BeanCounter.Calculator.Combinations
{
    using Input;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a particularly order in which the features are to be implemented.
    /// </summary>
    public interface ICombination
    {
        /// <summary>
        /// Gets the features in a particular order.
        /// </summary>
        IReadOnlyList<Feature> Features { get; }
    }
}
