using System;

class Ticket
{
	
	static int TicketNumber = 10;
	public static void Count()
	{


        TicketNumber++;

        Console.WriteLine("Your ticket number is {0}", TicketNumber);
	    
    }
    
	static void Main(string[] args)
	{
        char TicketDemand;
        do
        {
            Console.WriteLine("Do you want a ticket? (Y/N) ");
            TicketDemand = Convert.ToChar(Console.ReadLine());
            if ((TicketDemand == 'Y') || (TicketDemand == 'y'))
            {

                Count();
            }
        }while (TicketDemand == 'Y' || TicketDemand == 'y');

        Console.WriteLine("You should sell the tickets");
        Console.ReadLine();
        
	}
}