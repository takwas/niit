using System;
class GameDetails
   {
     string Fname;
     string Lname;
     int NoOfPlayers;
     int Level;
   
	public void Accept_game_details()
    	 {
       
      	Console.WriteLine("Enter your first name:");       
      	Fname=Console.ReadLine();      
      	Console.WriteLine("Enter your last name:");
       	Lname=Console.ReadLine();
       	Console.WriteLine("Enter number of players:");
       	NoOfPlayers= Convert.ToInt32(Console.ReadLine());
       	Console.WriteLine("Enter complexity level number:");
       	Level=Convert.ToInt32(Console.ReadLine());
     }
     public void Display_game_details()
     {
        Console.WriteLine("\nThe details entered are as follows:");
		Console.Write("First name: ");
        Console.WriteLine(Fname);
        Console.Write("Last name: ");
	    Console.WriteLine(Lname);
        Console.Write("Number of players:");
	    Console.WriteLine(NoOfPlayers);
      	Console.Write("Level:");
	    Console.WriteLine(Level);
     }
}

class My
{

	static void Main(string[] args)
	{
    	GameDetails Bingo= new GameDetails();
    	Bingo.Accept_game_details();
    	Bingo.Display_game_details();
    	 
	}
}