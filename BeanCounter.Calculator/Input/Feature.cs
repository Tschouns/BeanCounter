namespace BeanCounter.Calculator.Input
{
    using BeanCounter.Base.RuntimeChecks;

    /// <summary>
    /// Represents a feature to be implemented.
    /// </summary>
    public class Feature
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Feature"/> class.
        /// </summary>
        public Feature(
            string identifier,
            decimal costOfDelayPerWeek,
            decimal developmentDurationInDays)
        {
            ArgumentChecks.AssertNotNullOrEmpty(identifier, nameof(identifier));
            ArgumentChecks.AssertNotNegative(costOfDelayPerWeek, nameof(costOfDelayPerWeek));
            ArgumentChecks.AssertNotNegative(developmentDurationInDays, nameof(developmentDurationInDays));

            this.Identifier = identifier;
            this.CostOfDelayPerWeek = costOfDelayPerWeek;
            this.DevelopmentDurationInDays = developmentDurationInDays;
        }

        /// <summary>
        /// Gets the feature idetifier.
        /// </summary>
        public string Identifier { get; }

        /// <summary>
        /// Gets the estimated cost of delay per week (expressed in man-days).
        /// </summary>
        public decimal CostOfDelayPerWeek { get; }

        /// <summary>
        /// Gets the estimated development duration in days.
        /// </summary>
        public decimal DevelopmentDurationInDays { get; }
    }
}