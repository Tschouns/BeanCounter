namespace BeanCounter.ProjectSerializer.Services.Xml.XmlModel.Version1
{
    using System;

    /// <summary>
    /// Represents a backlog item in the XML structure.
    /// </summary>
    public class XmlBacklogItem
    {
        /// <summary>
        /// Gets or sets the item ID.
        /// </summary>
        public Guid ItemId { get; }

        /// <summary>
        /// Gets or sets the rank.
        /// </summary>
        public int Rank { get; set; }
    }
}
