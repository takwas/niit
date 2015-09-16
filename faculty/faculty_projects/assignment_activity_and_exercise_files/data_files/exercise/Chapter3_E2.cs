using System;

class EvenOddNumber
{
    static void Main(string[] args)
    {
         int Number;
        Console.WriteLine("Enter the number you want to check an Even or Odd Number");
        Number = Convert.ToInt32(Console.ReadLine());
       
        if (Number % 2 == 0)
        {
            Console.WriteLine("The number you have entered is an Even number");
        }
        else
        {
            Console.WriteLine("The number you have entered is an Odd number");
        }
        Console.ReadLine();
   
    }


}
