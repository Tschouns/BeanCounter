namespace BeanCounter.Calculator.Test.Combinations
{
    using Calculator.Combinations;
    using Input;
    using Input.Constraints;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Services.Combinations;
    using Services.Constraints;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Tests the <see cref="CreateCombinationsServiceIntegrationTests"/> class.
    /// </summary>
    [TestClass]
    public class CreateCombinationsServiceIntegrationTests
    {
        [TestMethod]
        public void CreateCombinations_1000FeaturesNoConstraints_Generate10000UniqueCombinations()
        {
            // Arrange
            var numberOfFeatures = 1000;

            var features = new List<Feature>();
            for (int i = 0; i < numberOfFeatures; i++)
            {
                features.Add(new Feature($"feature #{i}", 1, 5));
            }

            var constraints = new List<IConstraint>();

            var candidate = new CreateCombinationsService(
                new ConstraintValidatorFactory(),
                new RandomCombinationGenerator(new PseudoRandomizer(12567)));

            // Act
            var maxNumberOfAttempts = 10000;
            var combinationList = new List<ICombination>();
            candidate.CreateCombinations(
                features,
                constraints,
                c => combinationList.Add(c),
                () => true,
                maxNumberOfAttempts);

            // Assert
            Assert.AreEqual(maxNumberOfAttempts, combinationList.Count);
            Assert.AreEqual(combinationList.Count, combinationList.Distinct().Count());
        }
    }
}
