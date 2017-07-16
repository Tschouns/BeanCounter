namespace BeanCounter.Calculator.Services.Cost
{
    using BeanCounter.Calculator.Input;

    /// <summary>
    /// Provides helper methods to calculate cost.
    /// </summary>
    public interface ICostCalculationHelper
    {
        /// <summary>
        /// Calculates the absolute cost for the specified feature.
        /// </summary>
        decimal CalculateAbsoluteCostForFeature(
            Feature feature,
            decimal daysUntilImplementationStart);
    }
}
