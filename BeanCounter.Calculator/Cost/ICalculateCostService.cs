namespace BeanCounter.Calculator.Cost
{
    using BeanCounter.Calculator.Combinations;
    using Input.Effects;
    using System.Collections.Generic;

    /// <summary>
    /// Calculates the total cost of specific combinations of feature.
    /// </summary>
    public interface ICalculateCostService
    {
        /// <summary>
        /// Calculates the total cost, based on cost of delay and the specified effects, for
        /// the specified combination of features.
        /// </summary>
        CombinationCostResult Calculate(ICombination combination, IEnumerable<IEffect> effects);
    }
}
