namespace BeanCounter.ProjectSerializer.Services.Xml.XmlModel.Version1
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents an item in the XML structure.
    /// </summary>
    [DataContract(Name = "Item", Namespace = "http://www.github.com/tschouns/beancounter")]
    public class XmlItem
    {
        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        [DataMember]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the public identifier.
        /// </summary>
        [DataMember]
        public string PublicIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the item summary.
        /// </summary>
        [DataMember]
        public string Summary { get; set; }

        /// <summary>
        /// Gets the item summary.
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the estimated cost of delay per day.
        /// </summary>
        [DataMember]
        public decimal EstimatedCostOfDelayPerDay { get; set; }

        /// <summary>
        /// Gets or sets the estimated development duration in days.
        /// </summary>
        [DataMember]
        public decimal EstimatedDevelopmentDurationInDays { get; set; }
    }
}
