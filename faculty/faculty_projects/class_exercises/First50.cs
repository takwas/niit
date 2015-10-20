
using System;

class First50
{
	public static void Main(string[] args)
	{
	
		Console.WriteLine("\nUsing a while loop...\n");
		int num = 1;
		
		while(num<=50)
		{
			Console.Write("{0};\t", num);
			num++;
		}
		
		Console.WriteLine();
		Console.ReadLine();		// Add this at the end of your program so that it doesn't exit automatically
	}
}
