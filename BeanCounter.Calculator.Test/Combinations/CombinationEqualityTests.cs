namespace BeanCounter.Calculator.Combinations.Test
{
    using Input;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Services.Combinations;
    using System.Collections.Generic;

    /// <summary>
    /// Tests the <see cref="Combination"/> class for correctness of equality comparisons.
    /// </summary>
    [TestClass]
    public class CombinationEqualityTests
    {
        private readonly Feature _feature1 = new Feature("Uno", 1, 3);
        private readonly Feature _feature2 = new Feature("Due", 1, 3);
        private readonly Feature _feature3 = new Feature("Tre", 1, 3);

        [TestMethod]
        public void Equality_ForIdenticalInstances_IsTrue()
        {
            // Arrange
            var a = new Combination(CreateList(this._feature1));
            var b = a;

            // Act / Assert
            AssertEqualityChecksAreTrue(a, b);
        }

        [TestMethod]
        public void Equality_ForEqualCombinations_IsTrue()
        {
            // Arrange
            var a = new Combination(CreateList(this._feature1));
            var b = new Combination(CreateList(this._feature1));

            // Act / Assert
            AssertEqualityChecksAreTrue(a, b);
        }

        [TestMethod]
        public void Equality_ForEqualLongerCombinations_IsTrue()
        {
            // Arrange
            var a = new Combination(CreateList(this._feature1, this._feature2, this._feature3));
            var b = new Combination(CreateList(this._feature1, this._feature2, this._feature3));

            // Act / Assert
            AssertEqualityChecksAreTrue(a, b);
        }

        [TestMethod]
        public void Equality_ForDifferentCombinations_IsFalse()
        {
            // Arrange
            var a = new Combination(CreateList(this._feature1));
            var b = new Combination(CreateList(this._feature2));

            // Act / Assert
            AssertEqualityChecksAreFalse(a, b);
        }

        [TestMethod]
        public void Equality_ForSimilarCombinations_IsFalse()
        {
            // Arrange
            var a = new Combination(CreateList(this._feature1, this._feature2));
            var b = new Combination(CreateList(this._feature1, this._feature3));

            // Act / Assert
            AssertEqualityChecksAreFalse(a, b);
        }

        [TestMethod]
        public void Equality_OneIsNull_IsFalse()
        {
            // Arrange
            var a = new Combination(CreateList(this._feature1, this._feature2));
            Combination b = null;

            // Act / Assert
            Assert.IsFalse(a == b);
            Assert.IsTrue(a != b);
            Assert.IsFalse(a.Equals(b));
        }

        [TestMethod]
        public void Equality_OneIsDifferentType_IsFalse()
        {
            // Arrange
            var a = new Combination(CreateList(this._feature1, this._feature2));
            var b = this._feature1;

            // Act / Assert
            Assert.IsFalse(a.Equals(b));
        }

        private static IReadOnlyList<Feature> CreateList(
            Feature feature,
            params Feature[] furtherFeatures)
        {
            var list = new List<Feature>();
            list.Add(feature);

            foreach (var f in furtherFeatures)
            {
                list.Add(f);
            }

            return list;
        }

        private static void AssertEqualityChecksAreTrue(Combination a, Combination b)
        {
            // equality operator
            Assert.IsTrue(a == b);

            // inequality operator (this one's false!)
            Assert.IsFalse(a != b);

            // Equals method
            Assert.IsTrue(a.Equals(b));
            Assert.IsTrue(b.Equals(a));

            // hash code
            Assert.IsTrue(a.GetHashCode() == b.GetHashCode());
        }

        private static void AssertEqualityChecksAreFalse(Combination a, Combination b)
        {
            // equality operator
            Assert.IsFalse(a == b);

            // inequality operator (this one's true!)
            Assert.IsTrue(a != b);

            // Equals method
            Assert.IsFalse(a.Equals(b));
            Assert.IsFalse(b.Equals(a));

            // hash code
            Assert.IsFalse(a.GetHashCode() == b.GetHashCode());
        }
    }
}
