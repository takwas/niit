using System;
class Book
{
	string BookCat;
	string FirstName;
	string LastName;
	int IsbnNo;
	int NoOfCopies;

public void Display()
{			Console.WriteLine("\nThe following are the details of the Book: ");
            Console.Write("Category of the Book: ");
            Console.WriteLine(BookCat) ;
            Console.Write("Name of the Author: ");
            Console.Write(FirstName);
            Console.WriteLine(" {0}",LastName);
            Console.Write("ISBN Number: ");
     	    Console.WriteLine(IsbnNo);
            Console.Write("Number of Copies: ");
            Console.WriteLine(NoOfCopies);
     
     }

public void Get()
     {
            Console.WriteLine("Please enter the details of the Book ");
			Console.WriteLine("Enter the Category of the Book (Fiction/Nonfiction): ");
            BookCat=Console.ReadLine();
            Console.WriteLine("First Name of the Author: ");
            FirstName=Console.ReadLine();
            Console.WriteLine("Last Name of the Author: ");
            LastName=Console.ReadLine();
            Console.WriteLine("ISBN Number: ");
            IsbnNo= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of Copies: ");
            NoOfCopies=Convert.ToInt32(Console.ReadLine());
     }
}

class MyClass
{
	static void Main(string[] args)
	{
	     Book My_Fav = new Book();
	     My_Fav.Get();	
	     My_Fav.Display();
	     Console.ReadLine();

	}
}