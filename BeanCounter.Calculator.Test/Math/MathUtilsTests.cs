namespace BeanCounter.Calculator.Test.Math
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Services.Math;

    /// <summary>
    /// Tests the <see cref="MathUtils"/> class.
    /// </summary>
    [TestClass]
    public class MathUtilsTests
    {
        [TestMethod]
        public void Factorial_0_Returns1()
        {
            // Arrange
            var number = 0;

            // Act
            var factorial = MathUtils.Factorial(number);

            // Assert
            ulong expectedFactorial = 1;
            Assert.AreEqual(expectedFactorial, factorial);
        }

        [TestMethod]
        public void Factorial_1_Returns1()
        {
            // Arrange
            var number = 1;

            // Act
            var factorial = MathUtils.Factorial(number);

            // Assert
            ulong expectedFactorial = 1;
            Assert.AreEqual(expectedFactorial, factorial);
        }

        [TestMethod]
        public void Factorial_2_Returns2()
        {
            // Arrange
            var number = 2;

            // Act
            var factorial = MathUtils.Factorial(number);

            // Assert
            ulong expectedFactorial = 2;
            Assert.AreEqual(expectedFactorial, factorial);
        }

        [TestMethod]
        public void Factorial_3_Returns6()
        {
            // Arrange
            var number = 3;

            // Act
            var factorial = MathUtils.Factorial(number);

            // Assert
            ulong expectedFactorial = 6;
            Assert.AreEqual(expectedFactorial, factorial);
        }

        [TestMethod]
        public void Factorial_4_Returns24()
        {
            // Arrange
            var number = 4;

            // Act
            var factorial = MathUtils.Factorial(number);

            // Assert
            ulong expectedFactorial = 24;
            Assert.AreEqual(expectedFactorial, factorial);
        }

        [TestMethod]
        public void Factorial_5_Returns120()
        {
            // Arrange
            var number = 5;

            // Act
            var factorial = MathUtils.Factorial(number);

            // Assert
            ulong expectedFactorial = 120;
            Assert.AreEqual(expectedFactorial, factorial);
        }

        [TestMethod]
        public void Factorial_6_Returns720()
        {
            // Arrange
            var number = 6;

            // Act
            var factorial = MathUtils.Factorial(number);

            // Assert
            ulong expectedFactorial = 720;
            Assert.AreEqual(expectedFactorial, factorial);
        }

        [TestMethod]
        public void Factorial_7_Returns5040()
        {
            // Arrange
            var number = 7;

            // Act
            var factorial = MathUtils.Factorial(number);

            // Assert
            ulong expectedFactorial = 5040;
            Assert.AreEqual(expectedFactorial, factorial);
        }

        [TestMethod]
        public void Factorial_14_Returns87178291200()
        {
            // Arrange
            var number = 14;

            // Act
            var factorial = MathUtils.Factorial(number);

            // Assert
            ulong expectedFactorial = 87178291200;
            Assert.AreEqual(expectedFactorial, factorial);
        }
    }
}
