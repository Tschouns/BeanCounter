namespace BeanCounter.ProjectSerializer.Services.Xml.XmlModel.Version1
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a backlog in the XML structure.
    /// </summary>
    public class XmlBacklog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XmlBacklog"/> class.
        /// </summary>
        public XmlBacklog()
        {
            this.BacklogItems = new List<XmlBacklogItem>();
        }

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the backlog items.
        /// </summary>
        public IList<XmlBacklogItem> BacklogItems { get; }
    }
}
