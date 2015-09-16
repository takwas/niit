using System;

/*
 * Fibonacci numbers
 * In mathematics, the Fibonacci numbers or
 * Fibonacci sequence are the numbers in
 * the following integer sequence:
 *
 *		1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...;
 *
 * or (often, in modern usage):
 *
 *		0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...;
 *
 * 
 * By definition, the first two numbers in the
 * Fibonacci sequence are either 1 and 1,
 * or 0 and 1, depending on the chosen
 * starting point of the sequence, and each
 * subsequent number is the sum of the previous two.
 *
 *
 * Source: Wikipedia - https://en.wikipedia.org/wiki/Fibonacci_number
 */
class Fib200
{



	/*
	 * A function/method to generate and
	 * print Fibonacci numbers up to the nth
	 * Fibonacci number.
	 */	
	static void FibN(int n)
	{
		int a = 0;
		int b = 1;
		int c;

		// a loop to go through the series of Fibonacci numbers		
		for (int i = 1; i <= n; i++)
		{
			
			if (i == 1)
			{
				Console.WriteLine("Fib 1:\t{0}", a);
			}
			
			else if (i == 2)
			{
				Console.WriteLine("Fib 2:\t{0}", b);
			}
			
			else
			{
				c = a+b;
				a = b;
				b = c;

				Console.WriteLine("Fib {0}:\t{1}", i, c);
			}
			
		}
		
	}

	public static void Main(string[] args)
	{
		
		// Print some user friendly messages to the user
		Console.WriteLine("\n\nProgram running ...\n");
		Console.WriteLine("========== MMS-SE Fibonacci Generator ==========");


		// Call the Fibonacci number generator function (created above)		
		FibN(20);

		
		Console.WriteLine("\nPress [Enter] to exit ...")	;

		Console.ReadLine();		// Add this at the end of your program so that it doesn't exit automatically
		
	}

}
