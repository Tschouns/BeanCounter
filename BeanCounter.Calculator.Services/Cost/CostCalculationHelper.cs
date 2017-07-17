namespace BeanCounter.Calculator.Services.Cost
{
    using System;
    using BeanCounter.Calculator.Input;
    using Base.RuntimeChecks;

    /// <summary>
    /// See <see cref="ICostCalculationHelper"/>.
    /// </summary>
    public class CostCalculationHelper : ICostCalculationHelper
    {
        /// <summary>
        /// See <see cref="ICostCalculationHelper.CalculateAbsoluteCostOfDelayForFeature"/>.
        /// </summary>
        public decimal CalculateAbsoluteCostOfDelayForFeature(
            Feature feature,
            decimal daysUntilImplementationStart)
        {
            ArgumentChecks.AssertNotNull(feature, nameof(feature));
            ArgumentChecks.AssertNotNegative(daysUntilImplementationStart, nameof(daysUntilImplementationStart));

            var daysUntilFinished = daysUntilImplementationStart + feature.DevelopmentDurationInDays;
            var absoluteCostOfDelay = daysUntilFinished * feature.CostOfDelayPerDay;

            return absoluteCostOfDelay;
        }
    }
}
