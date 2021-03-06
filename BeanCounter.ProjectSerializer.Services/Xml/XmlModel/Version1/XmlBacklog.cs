﻿namespace BeanCounter.ProjectSerializer.Services.Xml.XmlModel.Version1
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a backlog in the XML structure.
    /// </summary>
    [DataContract(Name = "Backlog", Namespace = "http://www.github.com/tschouns/beancounter")]
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
        [DataMember]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets the backlog items.
        /// </summary>
        [DataMember]
        public IList<XmlBacklogItem> BacklogItems { get; }
    }
}
