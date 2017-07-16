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
        /// See <see cref="ICostCalculationHelper.CalculateAbsoluteCostForFeature(Feature, decimal)"/>.
        /// </summary>
        public decimal CalculateAbsoluteCostForFeature(
            Feature feature,
            decimal daysUntilImplementationStart)
        {
            ArgumentChecks.AssertNotNull(feature, nameof(feature));
            ArgumentChecks.AssertNotNegative(daysUntilImplementationStart, nameof(daysUntilImplementationStart));

            var daysUntilFinished = daysUntilImplementationStart + feature.DevelopmentDurationInDays;
            var absoluteCostOfDelay = daysUntilFinished * feature.CostOfDelayPerDay;
            var absoluteCostOfFeature = absoluteCostOfDelay + feature.DevelopmentDurationInDays;

            return absoluteCostOfFeature;
        }
    }
}
