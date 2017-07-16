namespace BeanCounter.Calculator.Test.Combinations
{
    using Input;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Services.Combinations;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Tests the <see cref="RandomCombinationGenerator"/> class.
    /// </summary>
    [TestClass]
    public class RandomCombinationGeneratorTests
    {
        private readonly Feature _feature1 = new Feature("Uno", 1, 3);
        private readonly Feature _feature2 = new Feature("Due", 1, 3);
        private readonly Feature _feature3 = new Feature("Tre", 1, 3);

        [TestMethod]
        public void GenerateCombination_RandomIndexIsAlwaysZero_ResultingOrderStaysTheSame()
        {
            // Arrange
            var candidate = new RandomCombinationGenerator(new FakeRandomizer(0));

            // Act
            var combination = candidate.GenerateCombination(new[]
            {
                this._feature1,
                this._feature2,
                this._feature3
            });

            // Assert
            Assert.AreEqual(3, combination.Features.Count);
            Assert.AreEqual(this._feature1, combination.Features[0]);
            Assert.AreEqual(this._feature2, combination.Features[1]);
            Assert.AreEqual(this._feature3, combination.Features[2]);
        }

        [TestMethod]
        public void GenerateCombination_RandomIndexIsAlwaysLastPosition_ResultingOrderIsInverted()
        {
            // Arrange
            var candidate = new RandomCombinationGenerator(new FakeRandomizer(2, 1, 0));

            // Act
            var combination = candidate.GenerateCombination(new[]
            {
                this._feature1,
                this._feature2,
                this._feature3
            });

            // Assert
            Assert.AreEqual(3, combination.Features.Count);
            Assert.AreEqual(this._feature3, combination.Features[0]);
            Assert.AreEqual(this._feature2, combination.Features[1]);
            Assert.AreEqual(this._feature1, combination.Features[2]);
        }

        [TestMethod]
        public void GenerateCombination_OnlyOneFeature_ResultingListContainsOnlyOneFeature()
        {
            // Arrange
            var candidate = new RandomCombinationGenerator(new FakeRandomizer(4231));

            // Act
            var combination = candidate.GenerateCombination(new[]
            {
                this._feature1,
            });

            // Assert
            Assert.AreEqual(1, combination.Features.Count);
            Assert.AreEqual(this._feature1, combination.Features[0]);
        }

        [TestMethod]
        public void GenerateCombination_WildRandomIndices_ResultingListContainsAllFeature()
        {
            // Arrange
            var candidate = new RandomCombinationGenerator(new FakeRandomizer(53, 895348, 765));

            // Act
            var combination = candidate.GenerateCombination(new[]
            {
                this._feature1,
                this._feature2,
                this._feature3,
            });

            // Assert
            Assert.AreEqual(3, combination.Features.Count);
            Assert.IsTrue(combination.Features.Contains(this._feature1));
            Assert.IsTrue(combination.Features.Contains(this._feature2));
            Assert.IsTrue(combination.Features.Contains(this._feature3));
        }

        [TestMethod]
        public void GenerateCombination_LargeFeatureSet_ResultingListContainsAllFeature()
        {
            // Arrange
            var candidate = new RandomCombinationGenerator(new FakeRandomizer(
                6282527,
                8424440,
                2490841,
                10467771,
                2148918,
                12670802));

            var numberOfFeatures = 13523;
            var features = new List<Feature>();

            for (int i = 0; i < numberOfFeatures; i++)
            {
                features.Add(new Feature("Feature XY", 1, 3));
            }

            // Act
            var combination = candidate.GenerateCombination(features);

            // Assert
            Assert.AreEqual(numberOfFeatures, combination.Features.Count);
            foreach(var feature in features)
            {
                // Each feature is contained in the combination.
                Assert.IsTrue(combination.Features.Contains(feature));

                // Non of the features in the combinations have the same position as in the original
                // feature list. This is not always guaranteed, but is the case for the specified
                // input feature list and generated "random" numbers.
                var combinationFeatures = combination.Features.ToList();
                Assert.AreNotEqual(
                    features.IndexOf(feature),
                    combinationFeatures.IndexOf(feature));
            }
        }
    }
}