using NUnit.Framework;
using NutritionCalculatorApp;

namespace TestProject1
{
    public class CaloricTests
    {
        // Тестваме CalculateCaloric за положително N
        [Test]
        public void CalculateCaloric_WithPositiveN_ShouldCalculateCumulativeIntake()
        {
            // Arrange
            int[] caloricValues = { 250, 300, 150, 200, 100 };
            int N = caloricValues.Length;
            string expectedOutput = "250\n550\n700\n900\n1000\n";

            // Act
            string actualOutput = NutritionCalculator.CalculateCaloric(N, caloricValues);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        // Тестваме CalculateCaloric за N <= 0
        [Test]
        public void CalculateCaloric_WithZeroOrNegativeN_ShouldReturnZero()
        {
            // Arrange
            int[] caloricValues = { };
            int N = 0;
            string expectedOutput = "0\n";

            // Act
            string actualOutput = NutritionCalculator.CalculateCaloric(N, caloricValues);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}

