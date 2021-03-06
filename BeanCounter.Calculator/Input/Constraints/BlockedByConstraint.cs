﻿namespace BeanCounter.Calculator.Input.Constraints
{
    using BeanCounter.Base.RuntimeChecks;

    /// <summary>
    /// Represents a constraint by which the implementation of one feature is
    /// a precondition for the inplementation of another.
    /// </summary>
    public class BlockedByConstraint : IConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockedByConstraint"/> class.
        /// </summary>
        public BlockedByConstraint(
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
