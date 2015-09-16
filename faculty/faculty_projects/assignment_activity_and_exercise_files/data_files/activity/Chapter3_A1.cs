using System;
namespace Calculation
{
     class CalculateNumber
    {
   
            int Number1, Number2;
             char option;
            int Result;
        
            public void Number()
            {
            Console.WriteLine("Enter the First number");
            Number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            Number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Main Menu");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");

            Console.WriteLine("Enter the Operation you want to perform");
            option = Convert.ToChar(Console.ReadLine());

            switch (option)
            {
                case '1':
                    Result = Number1 + Number2;
                    Console.WriteLine("The result of addition is:{0}", Result);
                    break;

                case '2':

                    Result = Number1 - Number2;
                    Console.WriteLine("The result of Subtraction is:{0}", Result);
                    break;

                case '3':

                    Result = Number1 * Number2;
                    Console.WriteLine("The result of Multiplication is:{0}", Result);
                    break;

                case '4':

                    Result = Number1 / Number2;
                    Console.WriteLine("The result of Division is:{0}", Result);
                    break;
                default:
                    Console.WriteLine("Invalid Option  ");
                    break;
            }


            Console.ReadLine();

        }
    }
    class ClassMain
    {
            static void Main(string[] args)
            {
                CalculateNumber obj = new CalculateNumber();
                obj.Number();
            }
    }

}
