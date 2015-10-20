using System;

class Quad
{
	public int GetRectArea(int length, int breadth)
	{
		int result;
		result = length* breadth;
		return result;
	}
	
	public int GetSquareArea(int length)
	{
		int result;
		result = length * length;
		return result;
	}
}



class AreaFinder
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Welcome");						// greet the user
		Console.WriteLine("==================");		// print empty new line
			
		Quad myFavQuad = new Quad();					// create new object of class Quad
		Quad myOtherQuad = new Quad();				// create another object of class Quad
		
		int rect_area = myOtherQuad.GetRectArea(15, 12);			// use object to access GetRectArea() method, calculate and send result back into variable rect_area
		Console.WriteLine(rect_area);											// print the value of rect_area to the user
		Console.WriteLine(myFavQuad.GetRectArea(15, 12));
		
		
		Console.WriteLine("The area of a rectangle with length: 10, and breadth: 20 is {0}", myOtherQuad.GetRectArea(10, 20));
		Console.WriteLine();
		
		Console.WriteLine("The area of a square with length: 15 is {0}",myOtherQuad.GetSquareArea(15));
		Console.WriteLine();
		
		
		Console.WriteLine("Press [ENTER] to exit ...");
		Console.ReadLine();
	}
}
