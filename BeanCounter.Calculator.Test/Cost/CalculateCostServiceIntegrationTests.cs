namespace BeanCounter.Calculator.Test.Cost
{
    using System.Collections.Generic;
    using System.Linq;
    using BeanCounter.Base.RuntimeChecks;
    using BeanCounter.Calculator.Combinations;
    using BeanCounter.Calculator.Cost;
    using BeanCounter.Calculator.Input;
    using BeanCounter.Calculator.Input.Constraints;
    using BeanCounter.Calculator.Input.Effects;
    using BeanCounter.Calculator.Services.Combinations;
    using BeanCounter.Calculator.Services.Constraints;
    using BeanCounter.Calculator.Services.Cost;
    using BeanCounter.Calculator.Test.Combinations;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Tests the <see cref="CalculateCostService"/> class.
    /// </summary>
    [TestClass]
    public class CalculateCostServiceIntegrationTests
    {
        [TestMethod]
        public void CalculateCostService_ThreeRuns200Features_MoreCombinationsYieldBetterResult()
        {
            // Arrange
            var numberOfFeatures = 50;

            var features = new List<Feature>();
            for (int i = 0; i < numberOfFeatures; i++)
            {
                var costOfDelay = i % 17 * 0.5m;
                var developmentDuration = i % 13;

                features.Add(new Feature($"feature #{i}", costOfDelay, developmentDuration));
            }

            var candidate = new CalculateCostService(new CostCalculationHelper());

            // Act
            var combinationsForFirstRun = CreateCombinations(features, 10);
            var resultsOfFirstRun = new List<CombinationCostResult>();
            foreach (var combination in combinationsForFirstRun)
            {
                var result = candidate.Calculate(combination, new IEffect[0]);

                resultsOfFirstRun.Add(result);
            }

            var combinationsForSecondRun = CreateCombinations(features, 1000);
            var resultsOfSecondRun = new List<CombinationCostResult>();
            foreach (var combination in combinationsForSecondRun)
            {
                var result = candidate.Calculate(combination, new IEffect[0]);

                resultsOfSecondRun.Add(result);
            }

            var combinationsForThirdRun = CreateCombinations(features, 100000);
            var resultsOfThirdRun = new List<CombinationCostResult>();
            foreach (var combination in combinationsForThirdRun)
            {
                var result = candidate.Calculate(combination, new IEffect[0]);

                resultsOfThirdRun.Add(result);
            }

            // Assert
            Assert.AreEqual(10, resultsOfFirstRun.Count);
            Assert.AreEqual(1000, resultsOfSecondRun.Count);
            Assert.AreEqual(100000, resultsOfThirdRun.Count);

            var rankedResultsOfFirstRun = resultsOfFirstRun.OrderBy(r => r.TotalCostOfDelay).ToList();
            var rankedResultsOfSecondRun = resultsOfSecondRun.OrderBy(r => r.TotalCostOfDelay).ToList();
            var rankedResultsOfThirdRun = resultsOfThirdRun.OrderBy(r => r.TotalCostOfDelay).ToList();

            var bestResultOfFirstRun = rankedResultsOfFirstRun.First();
            var bestResultOfSecondRun = rankedResultsOfSecondRun.First();
            var bestResultOfThirdRun = rankedResultsOfThirdRun.First();

            Assert.IsTrue(bestResultOfSecondRun.TotalCostOfDelay < bestResultOfFirstRun.TotalCostOfDelay);
            Assert.IsTrue(bestResultOfThirdRun.TotalCostOfDelay < bestResultOfSecondRun.TotalCostOfDelay);
        }

        private static IEnumerable<ICombination> CreateCombinations(
            IEnumerable<Feature> features,
            int numberOfCombinations)
        {
            ArgumentChecks.AssertNotNull(features, nameof(features));

            var createCombinationsService = new CreateCombinationsService(
                new ConstraintValidatorFactory(),
                new RandomCombinationGenerator(new PseudoRandomizer(1257)));

            var combinationList = new List<ICombination>();
            createCombinationsService.CreateCombinations(
                features,
                new IConstraint[0],
                c => combinationList.Add(c),
                () => combinationList.Count < numberOfCombinations,
                numberOfCombinations * 2);

            return combinationList;
        }
    }
}
