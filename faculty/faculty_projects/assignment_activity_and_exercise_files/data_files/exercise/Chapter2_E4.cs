using System;
class Vehicle
{
  public int Number_of_tyres;
}

class MyVehicle
{
	static void Main(string[] args)
	{
	Vehicle Motorcycle= new Vehicle();
    Vehicle Car = new Vehicle();
	Console.WriteLine("Enter the number of wheels in a car:");
    Car.Number_of_tyres=Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter the number of wheels in a Motorcycle:");
    Motorcycle.Number_of_tyres= Convert.ToInt32(Console.ReadLine());
   	Console.Write("\nThe number of wheels in a Car is ");
	Console.WriteLine(Car.Number_of_tyres);
	Console.Write("The number of wheels in a Motorcycle is ");
	Console.WriteLine(Motorcycle.Number_of_tyres);
	
	}
}
