using System;
namespace Printing
{
    class Book
    {
        int NumberOfPages;

        public void PrintPages()
        {
            Console.WriteLine("Now, the total number of pages in a book is " + NumberOfPages);
        }
        public void GetPages()
        {
            Console.WriteLine("Enter the number of pages you want to add in the book:");
            NumberOfPages = Convert.ToInt16(Console.ReadLine());
        }
        public static Book operator +(Book b1, int Value)
        {
            b1.NumberOfPages += Value;
            return b1;
        }

        public static void Main()
        {
            Book b1 = new Book();
            Console.WriteLine("The number of pages in the book is 1000");
            b1.GetPages(); //Accepts data
            b1 += 1000;
            
            b1.PrintPages();
            Console.ReadLine();
        }
    }
}
