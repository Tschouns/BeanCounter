namespace BeanCounter.Calculator.Input.Effects
{
    using BeanCounter.Base.RuntimeChecks;

    /// <summary>
    /// Represents an effect by which the implementation duration of a feature is reduced by an
    /// absolute amount, if another feature has been implemented previously.
    /// </summary>
    public class ReduceDurationAbsoluteEffect : IEffect
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReduceDurationAbsoluteEffect"/> class.
        /// </summary>
        public ReduceDurationAbsoluteEffect(
            Feature conditionFeature,
            Feature reducedFeature,
            decimal durationReductionInDays)
        {
            ArgumentChecks.AssertNotNull(conditionFeature, nameof(conditionFeature));
            ArgumentChecks.AssertNotNull(reducedFeature, nameof(reducedFeature));
            ArgumentChecks.AssertNotNegative(durationReductionInDays, nameof(durationReductionInDays));

            this.ConditionFeature = conditionFeature;
            this.ReducedFeature = reducedFeature;
            this.DurationReductionInDays = durationReductionInDays;
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
        /// Gets the number of days by which the implementation duration is reduced.
        /// </summary>
        public decimal DurationReductionInDays { get; }
    }
}
