namespace BeanCounter.ProjectSerializer.Services.Xml.XmlModel.Version1
{
    using System;

    /// <summary>
    /// Represents an item in the XML structure.
    /// </summary>
    public class XmlItem
    {
        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the public identifier.
        /// </summary>
        public string PublicIdentifier { get; }

        /// <summary>
        /// Gets or sets the item summary.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Gets the item summary.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the estimated cost of delay per day.
        /// </summary>
        public decimal EstimatedCostOfDelayPerDay { get; set; }

        /// <summary>
        /// Gets or sets the estimated development duration in days.
        /// </summary>
        public decimal EstimatedDevelopmentDurationInDays { get; set; }
    }
}
