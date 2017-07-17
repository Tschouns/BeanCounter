namespace BeanCounter.ProjectModel
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a <c>BeanCounter</c> project.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Project"/> class.
        /// </summary>
        public Project(Guid id)
        {
            this.Id = id;
            this.Items = new List<Item>();
            this.Backlogs = new List<Backlog>();
        }

        /// <summary>
        /// Gets the unique technical idetifier.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Gets or sets the project's title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets a list of all the items in the project.
        /// </summary>
        public IList<Item> Items { get; }

        /// <summary>
        /// Gets a list of the backlogs in the project.
        /// </summary>
        public IList<Backlog> Backlogs { get; }
    }
}
