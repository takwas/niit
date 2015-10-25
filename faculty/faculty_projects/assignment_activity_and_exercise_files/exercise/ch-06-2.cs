using System;
namespace CalculateNumber
{

    class Calculate
    {
        
        static int number1;
        
        public void Display(int number)
        {
            Console.WriteLine(number);
            
        }
        Calculate()
        {
             number1++;
            Display(number1);
        }
        static Calculate()
        {
            number1 = 10;
            number1++;
          }
        static void Main(string[] args)
        {
            Calculate Cal1 = new Calculate();
            Calculate Cal2 = new Calculate();
            Console.ReadLine();
        }
    }
}
