namespace BeanCounter.Calculator.Input.Effects
{
    using BeanCounter.Base.RuntimeChecks;

    /// <summary>
    /// Represents an effect by which the implementation duration of a feature is reduced by a
    /// fraction, if another feature has been implemented previously.
    /// </summary>
    public class ReduceDurationRelativeEffect
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReduceDurationRelativeEffect"/> class.
        /// </summary>
        public ReduceDurationRelativeEffect(
            Feature conditionFeature,
            Feature reducedFeature,
            decimal durationReductionFactor)
        {
            ArgumentChecks.AssertNotNull(conditionFeature, nameof(conditionFeature));
            ArgumentChecks.AssertNotNull(reducedFeature, nameof(reducedFeature));
            ArgumentChecks.AssertNotNegative(durationReductionFactor, nameof(durationReductionFactor));

            this.ConditionFeature = conditionFeature;
            this.ReducedFeature = reducedFeature;
            this.DurationReductionFactor = durationReductionFactor;
        }

        /// <summary>
        /// Gets the feature which causes the effect.
        /// </summary>
        public Feature ConditionFeature { get; }

        /// <summary>
        /// Gets the feature which is influenced the effect.
        /// </summary>
        public Feature ReducedFeature { get; }

        /// <summary>
        /// Gets the factor which determines the reduction of the duration (i.e. the fraction which is subtracted).
        /// </summary>
        public decimal DurationReductionFactor { get; }
    }
}
