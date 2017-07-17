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
            decimal absoluteCostOfDelay)
        {
            ArgumentChecks.AssertNotNull(feature, nameof(feature));
            ArgumentChecks.AssertNotNegative(absoluteCostOfDelay, nameof(absoluteCostOfDelay));

            this.Feature = feature;
            this.AbsoluteCostOfDelay = absoluteCostOfDelay;
        }

        /// <summary>
        /// Gets the feature.
        /// </summary>
        public Feature Feature { get; }

        /// <summary>
        /// Gets the calculated absolute cost of delay for this feature, given its order in the combination.
        /// </summary>
        public decimal AbsoluteCostOfDelay { get; }
    }
}
