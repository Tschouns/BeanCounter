namespace BeanCounter.Calculator.Test.Constraints
{
    using Input;
    using Input.Constraints;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Services.Combinations;
    using Services.Constraints;
    using Services.Math;
    using System.Linq;

    /// <summary>
    /// Tests the <see cref="BlockedByConstraintValidator"/> class.
    /// </summary>
    [TestClass]
    public class BlockedByContraintValidatorTests
    {
        private readonly Feature _feature1 = new Feature("Uno", 1, 3);
        private readonly Feature _feature2 = new Feature("Due", 1, 3);
        private readonly Feature _feature3 = new Feature("Tre", 1, 3);

        [TestMethod]
        public void IsValid_BlockingFeatureIsFirst_ReturnsTrue()
        {
            // Arrange
            var candidate = new BlockedByConstraintValidator(new BlockedByConstraint(
                this._feature1,
                this._feature3));

            var combination = new Combination(new[]
                {
                    this._feature1,
                    this._feature2,
                    this._feature3
                }
                .ToList());

            // Act
            var isValid = candidate.IsValid(combination);

            // Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void IsValid_BlockingFeatureIsBeforeBlocked_ReturnsTrue()
        {
            // Arrange
            var candidate = new BlockedByConstraintValidator(new BlockedByConstraint(
                this._feature1,
                this._feature3));

            var combination = new Combination(new[]
                {
                    this._feature2,
                    this._feature1,
                    this._feature3
                }
                .ToList());

            // Act
            var isValid = candidate.IsValid(combination);

            // Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void IsValid_BlockedFeatureIsBeforeBlocking_ReturnsFalse()
        {
            // Arrange
            var candidate = new BlockedByConstraintValidator(new BlockedByConstraint(
                this._feature1,
                this._feature3));

            var combination = new Combination(new[]
                {
                    this._feature3,
                    this._feature2,
                    this._feature1
                }
                .ToList());

            // Act
            var isValid = candidate.IsValid(combination);

            // Assert
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void IsValid_BlockedFeatureIsNotInCombination_ReturnsTrue()
        {
            // Arrange
            var candidate = new BlockedByConstraintValidator(new BlockedByConstraint(
                this._feature1,
                this._feature3));

            var combination = new Combination(new[]
                {
                    this._feature1,
                    this._feature2
                }
                .ToList());

            // Act
            var isValid = candidate.IsValid(combination);

            // Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void IsValid_BlockingFeatureIsNotInCombination_ReturnsTrue()
        {
            // Arrange
            var candidate = new BlockedByConstraintValidator(new BlockedByConstraint(
                this._feature1,
                this._feature3));

            var combination = new Combination(new[]
                {
                    this._feature2,
                    this._feature3
                }
                .ToList());

            // Act
            var isValid = candidate.IsValid(combination);

            // Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void IsValid_NeitherFeatureIsInCombination_ReturnsTrue()
        {
            // Arrange
            var candidate = new BlockedByConstraintValidator(new BlockedByConstraint(
                this._feature1,
                this._feature3));

            var combination = new Combination(new[]
                {
                    this._feature2
                }
                .ToList());

            // Act
            var isValid = candidate.IsValid(combination);

            // Assert
            Assert.IsTrue(isValid);
        }
    }
}
