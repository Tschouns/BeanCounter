namespace BeanCounter.Calculator.Data
{
    /// <summary>
    /// Represents a feature to be implemented.
    /// </summary>
    public class Feature
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Feature"/> class.
        /// </summary>
        public Feature(
            decimal costOfDelayPerWeek,
            decimal developmentDurationInDays)
        {
            this.CostOfDelayPerWeek = costOfDelayPerWeek;
            this.DevelopmentDurationInDays = developmentDurationInDays;
        }

        /// <summary>
        /// Gets the estimated cost of delay per week (in any arbitrary currency).
        /// </summary>
        public decimal CostOfDelayPerWeek { get; }

        public decimal DevelopmentDurationInDays { get; }
    }
}
