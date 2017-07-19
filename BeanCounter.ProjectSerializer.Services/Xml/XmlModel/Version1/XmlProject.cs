namespace BeanCounter.ProjectSerializer.Services.Xml.XmlModel.Version1
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a project in the XML structure.
    /// </summary>
    public class XmlProject : XmlBaseProject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XmlProject"/> class.
        /// </summary>
        public XmlProject()
            : base("1")
        {
            this.Items = new List<XmlItem>();
            this.Backlogs = new List<XmlBacklog>();
        }

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        public IList<XmlItem> Items { get; }

        /// <summary>
        /// Gets or sets backlogs.
        /// </summary>
        public IList<XmlBacklog> Backlogs { get; }
    }
}
