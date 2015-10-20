using System;
namespace Square_Number
{

    class CalculateSquare
    {
        int number;
        public void Square(int number)
        {
            Console.WriteLine(number);
            number *= number;
            Console.WriteLine(number);
        }
        CalculateSquare()
        {
            number = 10;
            Square(number);
        }


        static void Main(string[] args)
        {
            CalculateSquare cal = new CalculateSquare();
            Console.ReadLine();
        }
    }
}
