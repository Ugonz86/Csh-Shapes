using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;
using System;

namespace Shapes.Tests
{
  [TestClass]
  public class SphereTests
  {

    [TestMethod]
    public void Sphere_GetVolume_VolumeOfSphere()
    {
      // Arrange
      Circle newCircle = new Circle(2);
      Sphere newSphere = new Sphere(newCircle);
      // Act
      double result = Math.Round(newSphere.GetVolume(),2);
      // Assert
      Assert.AreEqual(result, 25.13);
    }

    [TestMethod]
    public void Sphere_GetSurfaceArea_SurfaceAreaOfSphere()
    {
      // Arrange
      Circle newCircle = new Circle(2);
      Sphere newSphere = new Sphere(newCircle);
      // Act
      double result = Math.Round(newSphere.GetSurfaceArea(),2);
      // Assert
      Assert.AreEqual(result, 50.27);
    }

  }
}
