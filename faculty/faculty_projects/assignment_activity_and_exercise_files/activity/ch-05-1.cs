	   using System;
namespace MatrixSubtractionApp
{
    class MatrixSubtraction
    {
        public void subtract()
        {
            int[] Array1;
            int[] Array2;
            int[] Array3;

            Array1 = new int[3] { 2, 3, 4 };
            Array2 = new int[3] { 1, 2, 3 };
            Array3 = new int[3];
            Console.WriteLine("The Contents of Array 1 is :");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0}\t",Array1[i]);
            }
            Console.WriteLine("\n The Contents of Array 2 is:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0} \t",Array2[i]);
            }
            //Subtraction of Array
            for (int i = 0; i < 3; i++)
            {
                Array3[i] = Array1[i] - Array2[i];
            }
            //Display the Contents of Final Array
            Console.WriteLine("\n The Result of Array Subtraction is:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0} \t",Array3[i]);
            }


        }
        static void Main(string[] args)
        {
            MatrixSubtraction obj = new MatrixSubtraction();
            obj.subtract();
            Console.ReadLine();

        }
    }
}
