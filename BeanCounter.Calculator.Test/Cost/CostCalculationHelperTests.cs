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
        public void CalculateAbsoluteCostOfDelayForFeature_Cod1Dev5Delay10_Returns15()
        {
            // Arrange
            var candidate = new CostCalculationHelper();

            var costOfDelay = 1m;
            var developmentDuration = 5m;
            var delayUntilImplementationStart = 10m;

            var feature = new Feature("Feature XY", costOfDelay, developmentDuration);

            // Act
            var absoluteCost = candidate.CalculateAbsoluteCostOfDelayForFeature(
                feature,
                delayUntilImplementationStart);

            // Assert
            var expectedCost = 15m;

            Assert.AreEqual(expectedCost, absoluteCost);
        }

        [TestMethod]
        public void CalculateAbsoluteCostOfDelayForFeature_Cod12Dev5Delay10_Returns180()
        {
            // Arrange
            var candidate = new CostCalculationHelper();

            var costOfDelay = 12m;
            var developmentDuration = 5m;
            var delayUntilImplementationStart = 10m;

            var feature = new Feature("Feature XY", costOfDelay, developmentDuration);

            // Act
            var absoluteCost = candidate.CalculateAbsoluteCostOfDelayForFeature(
                feature,
                delayUntilImplementationStart);

            // Assert
            var expectedCost = 180m;

            Assert.AreEqual(expectedCost, absoluteCost);
        }

        [TestMethod]
        public void CalculateAbsoluteCostOfDelayForFeature_Cod2Dev4Delay0_Returns8()
        {
            // Arrange
            var candidate = new CostCalculationHelper();

            var costOfDelay = 2m;
            var developmentDuration = 4m;
            var delayUntilImplementationStart = 0m;

            var feature = new Feature("Feature XY", costOfDelay, developmentDuration);

            // Act
            var absoluteCost = candidate.CalculateAbsoluteCostOfDelayForFeature(
                feature,
                delayUntilImplementationStart);

            // Assert
            var expectedCost = 8m;

            Assert.AreEqual(expectedCost, absoluteCost);
        }

        [TestMethod]
        public void CalculateAbsoluteCostOfDelayForFeature_Cod0Dev5Delay100_Returns0()
        {
            // Arrange
            var candidate = new CostCalculationHelper();

            var costOfDelay = 0m;
            var developmentDuration = 5m;
            var delayUntilImplementationStart = 100m;

            var feature = new Feature("Feature XY", costOfDelay, developmentDuration);

            // Act
            var absoluteCost = candidate.CalculateAbsoluteCostOfDelayForFeature(
                feature,
                delayUntilImplementationStart);

            // Assert
            var expectedCost = 0m;

            Assert.AreEqual(expectedCost, absoluteCost);
        }

        [TestMethod]
        public void CalculateAbsoluteCostOfDelayForFeature_CodPoint1Dev7Delay60_Returns6Poin7()
        {
            // Arrange
            var candidate = new CostCalculationHelper();

            var costOfDelay = 0.1m;
            var developmentDuration = 7m;
            var delayUntilImplementationStart = 60m;

            var feature = new Feature("Feature XY", costOfDelay, developmentDuration);

            // Act
            var absoluteCost = candidate.CalculateAbsoluteCostOfDelayForFeature(
                feature,
                delayUntilImplementationStart);

            // Assert
            var expectedCost = 6.7m;

            Assert.AreEqual(expectedCost, absoluteCost);
        }
    }
}
