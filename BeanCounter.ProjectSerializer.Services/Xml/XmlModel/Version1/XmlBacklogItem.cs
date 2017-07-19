namespace BeanCounter.ProjectSerializer.Services.Xml.XmlModel.Version1
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a backlog item in the XML structure.
    /// </summary>
    [DataContract(Name = "BacklogItem", Namespace = "http://www.github.com/tschouns/beancounter")]
    public class XmlBacklogItem
    {
        /// <summary>
        /// Gets or sets the item ID.
        /// </summary>
        [DataMember]
        public Guid ItemId { get; set; }

        /// <summary>
        /// Gets or sets the rank.
        /// </summary>
        [DataMember]
        public int Rank { get; set; }
    }
}
