namespace BeanCounter.ProjectSerializer.Services.Xml.XmlModel.Version1
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a project in the XML structure.
    /// </summary>
    [DataContract(Name = "Project", Namespace = "http://www.github.com/tschouns/beancounter")]
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
        [DataMember]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [DataMember]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        [DataMember]
        public IList<XmlItem> Items { get; }

        /// <summary>
        /// Gets or sets backlogs.
        /// </summary>
        [DataMember]
        public IList<XmlBacklog> Backlogs { get; }
    }
}
