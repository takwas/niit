using System;
//Sorting of a Number
namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];



            Console.WriteLine("Enter the total array elements you want to store in an array");

            string s = Console.ReadLine();

            int x = Int32.Parse(s);

            Console.WriteLine("-----------------------");

            Console.WriteLine(" Enter array elements ");

            Console.WriteLine("-----------------------");

            for (int j = 0; j < x; j++)
            {

                string s1 = Console.ReadLine();

                a[j] = Int32.Parse(s1);

            }

            int limit = x - 1;

            for (int pass = 0; pass < x - 1; pass++)
            {

                for (int j = 0; j < limit - pass; j++)
                {

                    if (a[j] > a[j + 1])
                    {

                        int k = a[j];

                        a[j] = a[j + 1];

                        a[j + 1] = k;

                    }

                }

            }

            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Sorted elements of an array are:");

            for (int j = 0; j < x; j++)

                Console.WriteLine(a[j]);
            Console.ReadLine();
        }

    }
}
