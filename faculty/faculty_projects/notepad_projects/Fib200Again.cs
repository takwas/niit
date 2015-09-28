

using System;

class Fib200Again

{

	public static void Main(string[] args)
	{
		int a=0;
		int b=1;
		int c;
		
		
		
		for (int i=0; i<188; i++)
		{
		
			c = a+b;
			a = b;
			b = c;
			Console.WriteLine("Fib {0} : {1}", i, c);
		}
		
		Console.ReadLine();
	}

}
