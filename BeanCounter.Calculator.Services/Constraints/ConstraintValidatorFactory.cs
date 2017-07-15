namespace BeanCounter.Calculator.Services.Constraints
{
    using System;
    using BeanCounter.Calculator.Input.Constraints;
    using Base.RuntimeChecks;

    /// <summary>
    /// See <see cref="IConstraintValidatorFactory"/>.
    /// </summary>
    public class ConstraintValidatorFactory : IConstraintValidatorFactory
    {
        /// <summary>
        /// See <see cref="IConstraintValidatorFactory.CreateValidator(IConstraint)"/>.
        /// </summary>
        public IContraintValidator CreateValidator(IConstraint contraint)
        {
            ArgumentChecks.AssertNotNull(contraint, nameof(contraint));

            var blockedByContraint = contraint as BlockedByConstraint;
            if (blockedByContraint != null)
            {
                return new BlockedByConstraintValidator(blockedByContraint);
            }

            throw new ArgumentException("The specified constraint type is not supported.");
        }
    }
}
