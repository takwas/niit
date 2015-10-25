using System;
namespace UserDefineExep
{
    class TicketLimit
    {
        static void Main(string[] args)
        {
            Summer Summer = new Summer();
            try
            {
                Summer.CalculateTicket();
            }
            catch (TicketLimt e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
public class TicketLimt : ApplicationException
{
    
    public TicketLimt(string message)
        : base(message)
    {
        
    }
    
   
}
public class Summer
{
    int TotalTickets = 10;
    int count = 0;
    int FirstNumber;
    char choice = 'Y';

    //    Boolean flag = true;
    public void CalculateTicket()
    {


        while (choice == 'Y' || choice == 'y')
        {
            Console.WriteLine("Do you want to book the tickets(Y/N)");
            choice = Convert.ToChar(Console.ReadLine());
            if (choice == 'Y' || choice == 'y')
            {
                Console.WriteLine("Enter the number of tickets you want to book");
                FirstNumber = Convert.ToInt32(Console.ReadLine());
                count = count + FirstNumber;

                if (count > TotalTickets)
                    throw (new TicketLimt("Ticket not available"));
            }

        }
    }
}