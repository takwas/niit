
using System;

class First50DoWhile
{
	public static void Main(string[] args)
	{
		Console.WriteLine("\nUsing a do..while loop...\n");
		int num = 1;
		
		do
		{
			Console.Write("{0};\t", num);
			num++;

		}while(num<=50);
				
		Console.WriteLine();
		Console.ReadLine();		// Add this at the end of your program so that it doesn't exit automatically
	}
}
