using System;
namespace ArrayException
{
    
    class ArrayOutOfIndex
    {
        public void CalculateSum()
        {
            int sum=0;
            int[] number = new int[5] { 1, 2, 3, 4, 5 };

            try
            {
                for (int init = 1; init <= 5; init++)
                {
                    sum = sum + number[init];
                }
                Console.WriteLine("The sum of the array is : {0}", sum);
            }


            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
      }
    class ClassMain
    {
        static void Main(string[] args)
        {
            ArrayOutOfIndex obj = new ArrayOutOfIndex();
            obj.CalculateSum();
                Console.ReadLine();
        }
    }

}
