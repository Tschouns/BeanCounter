namespace BeanCounter.ProjectModel
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a backlog within a <c>BeanCounter</c>  project. A backlog contains
    /// a subset of the items in the project.
    /// </summary>
    public class Backlog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Backlog"/> class.
        /// </summary>
        public Backlog(Guid id)
        {
            this.Id = id;
            this.Items = new List<BacklogItem>();
        }

        /// <summary>
        /// Gets the unique technical idetifier.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Gets or sets the backlog's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the backlog items.
        /// </summary>
        public IList<BacklogItem> Items { get; }
    }
}
