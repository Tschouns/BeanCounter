namespace BeanCounter.Calculator.Test.Cost
{
    using Input;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Services.Cost;

    /// <summary>
    /// Tests the <see cref="CostCalculationHelper"/> class.
    /// </summary>
    [TestClass]
    public class CostCalculationHelperTests
    {
        [TestMethod]
        public void CalculateAbsoluteCostForFeature_Cod1Dev5Delay10_Returns20()
        {
            // Arrange
            var candidate = new CostCalculationHelper();

            var costOfDelay = 1m;
            var developmentDuration = 5m;
            var delayUntilImplementationStart = 10m;

            var feature = new Feature("Feature XY", costOfDelay, developmentDuration);

            // Act
            var absoluteCost = candidate.CalculateAbsoluteCostForFeature(
                feature,
                delayUntilImplementationStart);

            // Assert
            var expectedCost = 20m;

            Assert.AreEqual(expectedCost, absoluteCost);
        }

        [TestMethod]
        public void CalculateAbsoluteCostForFeature_Cod12Dev5Delay10_Returns185()
        {
            // Arrange
            var candidate = new CostCalculationHelper();

            var costOfDelay = 12m;
            var developmentDuration = 5m;
            var delayUntilImplementationStart = 10m;

            var feature = new Feature("Feature XY", costOfDelay, developmentDuration);

            // Act
            var absoluteCost = candidate.CalculateAbsoluteCostForFeature(
                feature,
                delayUntilImplementationStart);

            // Assert
            var expectedCost = 185m;

            Assert.AreEqual(expectedCost, absoluteCost);
        }

        [TestMethod]
        public void CalculateAbsoluteCostForFeature_Cod2Dev4Delay0_Returns12()
        {
            // Arrange
            var candidate = new CostCalculationHelper();

            var costOfDelay = 2m;
            var developmentDuration = 4m;
            var delayUntilImplementationStart = 0m;

            var feature = new Feature("Feature XY", costOfDelay, developmentDuration);

            // Act
            var absoluteCost = candidate.CalculateAbsoluteCostForFeature(
                feature,
                delayUntilImplementationStart);

            // Assert
            var expectedCost = 12m;

            Assert.AreEqual(expectedCost, absoluteCost);
        }

        [TestMethod]
        public void CalculateAbsoluteCostForFeature_Cod0Dev5Delay100_Returns5()
        {
            // Arrange
            var candidate = new CostCalculationHelper();

            var costOfDelay = 0m;
            var developmentDuration = 5m;
            var delayUntilImplementationStart = 100m;

            var feature = new Feature("Feature XY", costOfDelay, developmentDuration);

            // Act
            var absoluteCost = candidate.CalculateAbsoluteCostForFeature(
                feature,
                delayUntilImplementationStart);

            // Assert
            var expectedCost = 5m;

            Assert.AreEqual(expectedCost, absoluteCost);
        }

        [TestMethod]
        public void CalculateAbsoluteCostForFeature_CodPoint1Dev7Delay60_Returns13Poin7()
        {
            // Arrange
            var candidate = new CostCalculationHelper();

            var costOfDelay = 0.1m;
            var developmentDuration = 7m;
            var delayUntilImplementationStart = 60m;

            var feature = new Feature("Feature XY", costOfDelay, developmentDuration);

            // Act
            var absoluteCost = candidate.CalculateAbsoluteCostForFeature(
                feature,
                delayUntilImplementationStart);

            // Assert
            var expectedCost = 13.7m;

            Assert.AreEqual(expectedCost, absoluteCost);
        }
    }
}
