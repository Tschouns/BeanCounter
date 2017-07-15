namespace BeanCounter.Calculator.Input.Constraints
{
    using BeanCounter.Base.RuntimeChecks;

    /// <summary>
    /// Represents a constraint by which the implementation of one feature is
    /// a precondition for the inplementation of another.
    /// </summary>
    public class BlockedByContraint : IContraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockedByContraint"/> class.
        /// </summary>
        public BlockedByContraint(
            Feature blockingFeature,
            Feature blockedFeature)
        {
            ArgumentChecks.AssertNotNull(blockingFeature, nameof(blockingFeature));
            ArgumentChecks.AssertNotNull(blockedFeature, nameof(blockedFeature));

            this.BlockingFeature = blockingFeature;
            this.BlockedFeature = blockedFeature;
        }

        /// <summary>
        /// Gets the blocking feature.
        /// </summary>
        public Feature BlockingFeature { get; }

        /// <summary>
        /// Gets the blocked feature.
        /// </summary>
        public Feature BlockedFeature { get; }
    }
}
