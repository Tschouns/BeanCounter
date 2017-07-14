namespace BeanCounter.Calculator.Combinations
{
    using Input;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Provides methods to create proposed combinations of features for which the total cost
    /// can be calculated.
    /// </summary>
    public interface ICreateCombinationsService
    {
        /// <summary>
        /// Creates combinations from the specified features, and calls the specified
        /// <paramref name="addCombinationAction"/> delegate.
        /// It does this as long as the specified <paramref name="shouldKeepCreating"/>
        /// delegate returns <c>true</c> (or all possible combinations have been
        /// created).
        /// </summary>
        void CreateCombinations(
            IEnumerable<Feature> features,
            Action<ICombination> addCombinationAction,
            Func<bool> shouldKeepCreating);
    }
}
