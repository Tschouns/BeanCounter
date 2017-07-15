namespace BeanCounter.Calculator.Services.Constraints
{
    using Input.Constraints;

    /// <summary>
    /// Creates <see cref="IConstraintValidator"/> instances form contraints.
    /// </summary>
    public interface IConstraintValidatorFactory
    {
        /// <summary>
        /// Creates a validator which validates feature combinations against the
        /// specified constraint.
        /// </summary>
        IContraintValidator CreateValidator(IConstraint contraint);
    }
}
