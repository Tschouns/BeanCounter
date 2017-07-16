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
            decimal costOfDelayPerDay,
            decimal developmentDurationInDays)
        {
            ArgumentChecks.AssertNotNullOrEmpty(identifier, nameof(identifier));
            ArgumentChecks.AssertNotNegative(costOfDelayPerDay, nameof(costOfDelayPerDay));
            ArgumentChecks.AssertNotNegative(developmentDurationInDays, nameof(developmentDurationInDays));

            this.Identifier = identifier;
            this.CostOfDelayPerDay = costOfDelayPerDay;
            this.DevelopmentDurationInDays = developmentDurationInDays;
        }

        /// <summary>
        /// Gets the feature idetifier.
        /// </summary>
        public string Identifier { get; }

        /// <summary>
        /// Gets the estimated cost of delay per day (expressed in man-days).
        /// </summary>
        public decimal CostOfDelayPerDay { get; }

        /// <summary>
        /// Gets the estimated development duration in man-days.
        /// </summary>
        public decimal DevelopmentDurationInDays { get; }
    }
}