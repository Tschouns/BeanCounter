namespace BeanCounter.Calculator.Cost
{
    using Base.RuntimeChecks;
    using BeanCounter.Calculator.Combinations;
    using System.Collections.Generic;

    /// <summary>
    /// Cost calculation result for a specific <see cref="ICombination"/>.
    /// </summary>
    public class CombinationCostResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CombinationCostResult"/> class.
        /// </summary>
        public CombinationCostResult(
            ICombination combination,
            IReadOnlyList<FeatureCostResult> featureCostResults,
            decimal aTotalCostOfDelay)
        {
            ArgumentChecks.AssertNotNull(combination, nameof(combination));
            ArgumentChecks.AssertNotNull(featureCostResults, nameof(featureCostResults));
            ArgumentChecks.AssertNotNegative(aTotalCostOfDelay, nameof(aTotalCostOfDelay));

            this.Combination = combination;
            this.FeatureCostResults = featureCostResults;
            this.TotalCostOfDelay = aTotalCostOfDelay;
        }

        /// <summary>
        /// Gets the combination.
        /// </summary>
        public ICombination Combination { get; }

        /// <summary>
        /// Gets the calculated cost results for all the features.
        /// </summary>
        public IReadOnlyList<FeatureCostResult> FeatureCostResults { get; }

        /// <summary>
        /// Gets the total calculated cost of delay.
        /// </summary>
        public decimal TotalCostOfDelay { get; }
    }
}
