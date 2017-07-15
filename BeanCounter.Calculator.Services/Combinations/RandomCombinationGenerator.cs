namespace BeanCounter.Calculator.Services.Combinations
{
    using System;
    using System.Collections.Generic;
    using BeanCounter.Calculator.Input;
    using Base.RuntimeChecks;
    using System.Linq;

    /// <summary>
    /// See <see cref="ICombinationGenerator"/>. Generates random combinations.
    /// </summary>
    public class RandomCombinationGenerator : ICombinationGenerator
    {
        private readonly IRandomizer _randomizer;

        /// <summary>
        /// Initializes a new instance of the <see cref="RandomCombinationGenerator"/> class.
        /// </summary>
        public RandomCombinationGenerator(IRandomizer randomizer)
        {
            ArgumentChecks.AssertNotNull(randomizer, nameof(randomizer));

            this._randomizer = randomizer;
        }

        /// <summary>
        /// See <see cref="ICombinationGenerator.GenerateCombination(IEnumerable{Feature})"/>.
        /// </summary>
        public Combination GenerateCombination(IEnumerable<Feature> features)
        {
            ArgumentChecks.AssertNotNull(features, nameof(features));

            var remainingFeatures = features.ToList();
            var resultingFeatureList = new List<Feature>();

            while (remainingFeatures.Any())
            {
                // Select a random feature.
                var randomIndex = this._randomizer.GetRandomNumber() % remainingFeatures.Count;
                var randomFeature = remainingFeatures[randomIndex];

                // Move it from one list to the other.
                resultingFeatureList.Add(randomFeature);
                remainingFeatures.Remove(randomFeature);
            }

            return new Combination(resultingFeatureList);
        }
    }
}
