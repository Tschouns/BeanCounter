namespace BeanCounter.Calculator.Services.Constraints
{
    using Base.RuntimeChecks;
    using Calculator.Combinations;
    using BeanCounter.Calculator.Input.Constraints;
    using System.Linq;

    /// <summary>
    /// See <see cref="IContraintValidator"/>. Validates against a specific
    /// <see cref="BlockedByContraint"/>.
    /// </summary>
    public class BlockedByContraintValidator : IContraintValidator
    {
        private readonly BlockedByContraint _constraint;

        /// <summary>
        /// Initializes a new instance of the <see cref="BlockedByContraintValidator"/> class.
        /// </summary>
        public BlockedByContraintValidator(BlockedByContraint constraint)
        {
            ArgumentChecks.AssertNotNull(constraint, nameof(constraint));

            this._constraint = constraint;
        }

        /// <summary>
        /// See <see cref="IContraintValidator.IsValid(ICombination)"/>.
        /// </summary>
        public bool IsValid(ICombination combination)
        {
            ArgumentChecks.AssertNotNull(combination, nameof(combination));

            // Special case: if the blocking feature isn't in the list at all, the
            // constraint is not relevant. Otherwise the constraint would block all
            // combinations.
            if (!combination.Features.Contains(this._constraint.BlockingFeature))
            {
                return true;
            }

            foreach(var feature in combination.Features)
            {
                // If the blocked feature comes first...
                if (feature == this._constraint.BlockedFeature)
                {
                    return false;
                }

                // If the blocking feature comes first...
                if (feature == this._constraint.BlockingFeature)
                {
                    return true;
                }
            }

            // If neither the blocking nor the blocked feature is the list, the
            // constraint is not relevant.
            return true;
        }
    }
}
