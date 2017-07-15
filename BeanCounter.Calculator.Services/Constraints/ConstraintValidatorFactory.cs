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
        /// See <see cref="IConstraintValidatorFactory.CreateValidator(IContraint)"/>.
        /// </summary>
        public IContraintValidator CreateValidator(IContraint contraint)
        {
            ArgumentChecks.AssertNotNull(contraint, nameof(contraint));

            var blockedByContraint = contraint as BlockedByContraint;
            if (blockedByContraint != null)
            {
                return new BlockedByContraintValidator(blockedByContraint);
            }

            throw new ArgumentException("The specified constraint type is not supported.");
        }
    }
}
