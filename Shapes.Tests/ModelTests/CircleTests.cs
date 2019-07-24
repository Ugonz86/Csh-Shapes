using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;
using System;

namespace Shapes.Tests
{
  [TestClass]
  public class CircleTests
  {

    [TestMethod]
    public void Circle_GetArea_AreaOfCircle()
    {
      // Arrange
      Circle newCircle = new Circle(2);
      // Act
      double result = Math.Round(newCircle.GetCircumference(), 2);
      // Assert
      Assert.AreEqual(result, 12.57);
    }
  }
}
