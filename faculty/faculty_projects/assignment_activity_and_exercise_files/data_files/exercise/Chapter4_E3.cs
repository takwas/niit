using System;

 class Factorial
    {
        static long Fac1;
        public static bool Fac(long n, out long answer)
        {
            long k;
           
            bool ok = true;

            if (n < 0 || n>20)
            {
                ok = false;
               
            }
            else
            {
                Fac1 = 1;
                for (k = 2; k <= n; ++k)
                {
                    Fac1 = Fac1 * k;
                }
            }
            answer = Fac1;
            return ok;
            
        }
 }
    class Factorial1

    {

        static void Main(string[] args)
        {
            long Fac1;
            bool ok;
            long Number;
            Console.WriteLine("Enter the Number for calculating factorial(1-20):");
            Number=long.Parse(Console.ReadLine());

            ok = Factorial.Fac(Number, out Fac1);
            if (ok)
                Console.WriteLine("Factorial(" + Number + ")=" + Fac1);
            else
                Console.WriteLine("Incorrect value");
            Console.ReadLine();
        }
    }

