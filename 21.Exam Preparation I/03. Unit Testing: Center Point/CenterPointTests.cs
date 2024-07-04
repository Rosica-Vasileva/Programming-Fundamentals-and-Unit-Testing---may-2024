using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class CenterPointTests
{
    [Test]
    public void Test_GetClosest_WhenFirstPointIsCloser_ShouldReturnFirstPoint()
    {
        //Arrange
        string expected = "(1, 1)";
        //Act
        string actual = CenterPoint.GetClosest(1, 1, 2, 2);
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsCloser_ShouldReturnSecondPoint()
    {
        //Arrange
        string expected = "(1, 1)";
        //Act
        string actual = CenterPoint.GetClosest(2, 2, 1, 1);
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
        [Test]
    public void Test_GetClosest_WhenBothPointsHaveEqualDistance_ShouldReturnFirstPoint()
    {
        //Arrange
        string expected = "(2, 2)";
        //Act
        string actual = CenterPoint.GetClosest(2, 2, 2, 2);
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
    public void Test_GetClosest_WhenFirstPointIsNegative_ShouldReturnFirstPoint()
    {
        //Arrange
        string expected = "(-2, -2)";
        //Act
        string actual = CenterPoint.GetClosest(-2, -2, 2, 2);
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

        [Test]
    public void Test_GetClosest_WhenSecondPointIsNegative_ShouldReturnSecondPoint()
    {
        //Arrange
        string expected = "(-2, -2)";
        //Act
        string actual = CenterPoint.GetClosest(2, 2, -2, -2);
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
    }
