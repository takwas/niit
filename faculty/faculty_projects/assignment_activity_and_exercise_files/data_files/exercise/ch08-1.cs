using System;

namespace CalculateArea
{
     interface Area
    { 
          void calcArea(double Radius);
        
    }

    interface volume
    {
         void calc1(int Side);
        
    }

public class CircleCube:Area
{
   public void calcArea(double Radius)
  {
     double Pie = 3.14;   
     double Result;
     Result = Pie*Radius*Radius;
     Console.WriteLine("The Area of a circle is: {0}",Result);

     
  }
   public void calcVolume(int Side)
  {
        int Result;
        Result = Side*Side*Side;
      Console.WriteLine("The Volume of a cube is: {0}",Result);
  }

}
    class class1
    {
  public static void Main(string[] args)
  {
      CircleCube obj = new CircleCube();
      double Radius;
      int Side;

      Console.WriteLine("Enter the radius of the circle");
      Radius = Convert.ToDouble(Console.ReadLine());
      obj.calcArea(Radius);

      Console.WriteLine("Enter the side of the cube");
      Side = Convert.ToInt32(Console.ReadLine());
      obj.calcVolume(Side);

        Console.ReadLine();

  }

}

}
