using NUnit.Framework;

namespace TestApp.Tests
{
    public class PerfectSquareIntegersTests
    {
        [Test]
        public void Test_FindPerfectSquares_StartNumberGreaterThanEndNumber_ReturnsErrorMessage()
        {
            // Arrange
            PerfectSquareIntegers calculator = new PerfectSquareIntegers();

            // Act
            string result = PerfectSquareIntegers.FindPerfectSquares(10, 1);

            // Assert
            Assert.AreEqual("Start number should be less than end number.", result);
        }

        [Test]
        public void Test_FindPerfectSquares_GetSameSquareIntegerForStartAndEnd_ReturnsSameSquareInteger()
        {
            // Arrange
            PerfectSquareIntegers calculator = new PerfectSquareIntegers();

            // Act
            string result = PerfectSquareIntegers.FindPerfectSquares(1, 1);

            // Assert
            Assert.AreEqual("1",result);
        }

        [Test]
        public void Test_FindPerfectSquares_GetZeroAsSingleInteger_ReturnsZero()
        {
            // Arrange
            PerfectSquareIntegers calculator = new PerfectSquareIntegers();

            // Act
            string result = PerfectSquareIntegers.FindPerfectSquares(0, 0);

            // Assert
            Assert.AreEqual("0",result);
        }

        [Test]
        public void Test_FindPerfectSquares_RangeIncludesMultiplePerfectSquares_RetursOnlySquareIntegers()
        {
            // Arrange
            PerfectSquareIntegers calculator = new PerfectSquareIntegers();

            // Act
            string result = PerfectSquareIntegers.FindPerfectSquares(1, 50);

            // Assert
            Assert.AreEqual("1 4 9 16 25 36 49", result);
        }

        [Test]
        public void Test_FindPerfectSquares_NoPerfectSquaresInRange_ReturnsEmptyString()
        {
            // Arrange
            PerfectSquareIntegers calculator = new PerfectSquareIntegers();

            // Act
            var result = PerfectSquareIntegers.FindPerfectSquares(2, 3);

            // Assert
            Assert.AreEqual("", result);
        }
    }
}

