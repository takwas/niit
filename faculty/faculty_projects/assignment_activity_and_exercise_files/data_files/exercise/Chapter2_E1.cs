using System;
class Geometrical_Shapes
{
	double No_of_coordinates;
	double Area;
	string Color;

	public void Create()
	{
	Console.WriteLine("Enter Number of coordinates: ");
	No_of_coordinates=Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("Enter the Area: ");
	Area=Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("Enter the Color: ");
	Color=Console.ReadLine();
	
	}
	public void Display()
	{
	Console.WriteLine("THIS IS WHAT YOU ENTERED: \n");
	Console.Write("Number of coordinates: ");
	Console.WriteLine(No_of_coordinates);
	Console.Write("Area: ");
	Console.WriteLine(Area);
	Console.Write("Color: ");
	Console.WriteLine(Color);
	}
 }

class Classy
 {
 	static void Main(string[] args)
 	{
        Geometrical_Shapes Small_rectangle= new Geometrical_Shapes();
    	Small_rectangle.Create();
    	Small_rectangle.Display();
        Console.ReadLine();
    
 	}
}
