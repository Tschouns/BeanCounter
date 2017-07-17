namespace BeanCounter.ProjectModel
{
    using System;

    /// <summary>
    /// Represents an item within <c>BeanCounter</c> project.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        public Item(Guid id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Gets the unique technical idetifier.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Gets the public identifier, which can be used in the UI and with other external interfaces.
        /// </summary>
        public string PublicIdentifier { get; }

        /// <summary>
        /// Gets the item summary.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Gets the item summary.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the estimated cost of delay per day (in an arbitrary currency).
        /// </summary>
        public decimal EstimatedCostOfDelayPerDay { get; set; }

        /// <summary>
        /// Gets or sets the estimated development duration in days.
        /// </summary>
        public decimal EstimatedDevelopmentDurationInDays { get; set; }
    }
}
