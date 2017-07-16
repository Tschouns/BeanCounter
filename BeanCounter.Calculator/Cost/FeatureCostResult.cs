namespace BeanCounter.Calculator.Cost
{
    using Base.RuntimeChecks;
    using Input;

    /// <summary>
    /// Cost calculation result for a specific <see cref="Feature"/>.
    /// </summary>
    public class FeatureCostResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureCostResult"/> class.
        /// </summary>
        public FeatureCostResult(
            Feature feature,
            decimal totalCost)
        {
            ArgumentChecks.AssertNotNull(feature, nameof(feature));
            ArgumentChecks.AssertNotNegative(totalCost, nameof(totalCost));

            this.Feature = feature;
            this.AbsoluteCost = totalCost;
        }

        /// <summary>
        /// Gets the feature.
        /// </summary>
        public Feature Feature { get; }

        /// <summary>
        /// Gets the absolute calculated cost for this feature, given its order in the combination.
        /// </summary>
        public decimal AbsoluteCost { get; }
    }
}
