namespace BeanCounter.Calculator.Services.Cost
{
    using System;
    using System.Collections.Generic;
    using Calculator.Combinations;
    using BeanCounter.Calculator.Cost;
    using Input.Effects;
    using Base.RuntimeChecks;

    /// <summary>
    /// See <see cref="ICalculateCostService"/>.
    /// </summary>
    public class CalculateCostServices : ICalculateCostService
    {
        /// <summary>
        /// See <see cref="ICalculateCostService.Calculate(ICombination, IEnumerable{IEffect})"/>.
        /// </summary>
        public CombinationCostResult Calculate(ICombination combination, IEnumerable<IEffect> effects)
        {
            ArgumentChecks.AssertNotNull(combination, nameof(combination));
            ArgumentChecks.AssertNotNull(effects, nameof(effects));

            var totalDelayInDays = 0m;
            var totalCost = 0m;

            var featureCostResults = new List<FeatureCostResult>();
            foreach(var feature in combination.Features)
            {
                totalDelayInDays += feature.DevelopmentDurationInDays;

                var absoluteCostOfDelay = totalDelayInDays * feature.CostOfDelayPerWeek / 7;
                var absoluteCost = absoluteCostOfDelay + feature.DevelopmentDurationInDays;

                // TODO: apply effects...!!

                featureCostResults.Add(new FeatureCostResult(feature, absoluteCost));

                totalCost += absoluteCost;
            }

            throw new NotImplementedException();
        }
    }
}
