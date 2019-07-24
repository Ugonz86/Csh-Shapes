using System;


namespace Shapes.Models
{
  public class Circle
  {
    public double PI = Math.PI;
    public int Radius {get; set;}
    public int Diameter {get; set;}
    public Circle (int r)
    {
      Radius = r;
      Diameter = r * 2;
    }

    public double GetCircumference()
    {
      return (2 * PI * Radius);
    }

  }
}
