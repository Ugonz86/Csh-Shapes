using System;


namespace Shapes.Models
{
  public class Sphere
  {
    public double PI = Math.PI;
    public Circle Base { get; set; }

    public Sphere (Circle Radius)
    {
      Base = Radius;
    }
    public int GetVolume()
    {
      return 0;
    }
    public double GetSurfaceArea()
    {
      int r = Base.Radius;
      return (4* PI * r * r);
    }
  }
}
