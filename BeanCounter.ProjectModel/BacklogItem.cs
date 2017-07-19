namespace BeanCounter.ProjectModel
{
    using BeanCounter.Base.RuntimeChecks;

    /// <summary>
    /// Represents an item in a backlog.
    /// </summary>
    public class BacklogItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BacklogItem"/> class.
        /// </summary>
        public BacklogItem(Item item)
        {
            ArgumentChecks.AssertNotNull(item, nameof(item));

            this.Item = item;
        }

        /// <summary>
        /// Gets the item
        /// </summary>
        public Item Item { get; }

        /// <summary>
        /// Gets or sets the rank the item has within the backlog.
        /// </summary>
        public int Rank { get; set; }
    }
}
