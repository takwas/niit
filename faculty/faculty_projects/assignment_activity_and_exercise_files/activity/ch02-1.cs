using System;

	class TennisPlayer
	{
		string TennisPlayerName;
		int Rank;

		public void PrintPlayerDetails()
		{
			Console.WriteLine("\nThe details of the Tennis Players are: ");
			Console.Write("Name: ");
			Console.WriteLine(TennisPlayerName);
			Console.Write("Rank: ");
			Console.WriteLine(Rank);
			
		}
		public void GetPlayerDetails ()
		{
			Console.WriteLine("Enter the details of the Tennis Players ");
			Console.WriteLine("Enter TennisPlayer Name: ");
			TennisPlayerName=Console.ReadLine();
			Console.WriteLine("Rank: ");
			Rank=Convert.ToInt32(Console.ReadLine());
			
		}
	}

	class Tennis
	{
		public static void Main(string[] args)
		{
			TennisPlayer P1=new TennisPlayer();
			P1.GetPlayerDetails();
			P1.PrintPlayerDetails();

		}
	}
