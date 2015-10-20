/*
 * This program counts the number of times
 * a function is called.
 */
using System;

class Anonymous
{
	static int counter = 0;

	public static void Guess()
	{
		Console.WriteLine("You guessed!");			// print to the user to indicate that this function has been called
		counter = counter + 1;							// increase value of counter by one		
	}
	
	public static void CountFunction()
	{
		Console.WriteLine("You called  Guess()  {0} time(s)", counter);
	}
}



class FuncCountProg
{
	public static void Main(string[] args)
	{
		Anonymous.Guess();
		Anonymous.Guess();
		Anonymous.Guess();
		Anonymous.Guess();
		
		Anonymous.CountFunction();
		
		Console.WriteLine("\nPress [Enter] to exit ...");
		Console.ReadLine();
	}
}


/*
https://github.com/takwas/niit/tree/master/faculty/faculty_projects/assignment_activity_and_exercise_files
*/
