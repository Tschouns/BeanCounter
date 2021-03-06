﻿namespace BeanCounter.Calculator.Services.Cost
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
    public class CalculateCostService : ICalculateCostService
    {
        private readonly ICostCalculationHelper _costCalculationHelper;

        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateCostService"/> class.
        /// </summary>
        public CalculateCostService(ICostCalculationHelper costCalculationHelper)
        {
            ArgumentChecks.AssertNotNull(costCalculationHelper, nameof(costCalculationHelper));

            this._costCalculationHelper = costCalculationHelper;
        }

        /// <summary>
        /// See <see cref="ICalculateCostService.Calculate(ICombination, IEnumerable{IEffect})"/>.
        /// </summary>
        public CombinationCostResult Calculate(ICombination combination, IEnumerable<IEffect> effects)
        {
            ArgumentChecks.AssertNotNull(combination, nameof(combination));
            ArgumentChecks.AssertNotNull(effects, nameof(effects));

            var totalDelayInDays = 0m;
            var totalCostOfDelay = 0m;

            var featureCostResults = new List<FeatureCostResult>();
            foreach(var feature in combination.Features)
            {
                var absoluteCostOfDelay = this._costCalculationHelper.CalculateAbsoluteCostOfDelayForFeature(
                    feature,
                    totalDelayInDays);

                // TODO: add effects....

                featureCostResults.Add(new FeatureCostResult(feature, absoluteCostOfDelay));

                totalDelayInDays += feature.DevelopmentDurationInDays;
                totalCostOfDelay += absoluteCostOfDelay;
            }

            return new CombinationCostResult(
                combination,
                featureCostResults,
                totalCostOfDelay);
        }
    }
}
