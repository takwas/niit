using System;
using System.Threading;

public class Vehicle 
{
	private int id;   // id identifies each vehicle
	private static TollBooth toll = new TollBooth();  // only one toll booth
	public Vehicle(int id) 
	{
		// each vehicle has a different identifying number
		this.id = id;
	}

	public void exec() 
	{
		Console.WriteLine("Vehicle {0} starts journey",id+1);
		Random RandGen = new Random();
		int Rnd = RandGen.Next(0, 100);
		travel(Rnd);  // time taken from starting point to toll booth
		Console.WriteLine("Vehicle {0} arrives at toll",id+1);
		toll.useToll(this);  // current vehicle uses toll booth
		travel(Rnd); // time taken to cross bridge
		Console.WriteLine("Vehicle {0} has crossed bridge",id+1);
	}

	public int getVehicleId () 
	{
		return this.id;
	}

	public void travel(int time) 
	{
		int limit = 500000;
		for (int j=0; j < time; j++) 
		{
			for (int k=0; k < limit; k++) 
			{// do nothing
			};
		}
	}
}

public class TollBooth
{
	
	bool[] v;
	
	public TollBooth()
	{
		v=new bool[5];
		v[0]=false;
		v[1]=false;
		v[2]=false;
		v[3]=false;
		v[4]=false;

	}

	public void useToll(Vehicle vehicle)
	{

		Console.WriteLine("Vehicle {0} enters tollbooth",vehicle.getVehicleId()+1);

		
		vehicle.travel(50); // vehicle spends 50 time units in the toll booth
		Console.WriteLine("Vehicle {0} exits tollbooth",vehicle.getVehicleId()+1);


	}
}


public class Simulate
{
	private static int noOfVehicles = 5;
	private static Vehicle[] vehicles;
	public static void Main(String[] args) 
	{
				
		try
		{
			Simulate sm=new Simulate();
			vehicles=new Vehicle[5];
			for(int i=0;i<noOfVehicles;i++)
			{
				vehicles[i]=new Vehicle(i);
				Thread t = new Thread(new ThreadStart(vehicles[i].exec));
				t.Start();
				Thread.Sleep(1000);
			}

			
		}
		catch (Exception ex)
		{
			System.Console.WriteLine(ex);
			
		}

	}
}
