/*
 * This program counts the number of times
 * a function is called.
 */
using System;

class Anonymous
{
	static int counter = 0;

	public void Guess(string name)
	{
		Console.WriteLine("{0} guessed!", name);			// print to the user to indicate that this function has been called
		counter = counter + 1;							// increase value of counter by one		
	}
	
	public static void CountFunction()
	{
		Console.WriteLine("In total, Guess() was called {0} time(s)", counter);
	}
}



class FuncCountProg
{
	public static void Main(string[] args)
	{
		Anonymous hacker = new Anonymous();
		Anonymous tinkerer = new Anonymous();
		Anonymous coder = new Anonymous();
		
		hacker.Guess("Guy Hacker");
		tinkerer.Guess("Guy Tinkerer");
		coder.Guess("Guy Coder");
		hacker.Guess("Guy Hacker");
		coder.Guess("Guy Coder");
		hacker.Guess("Guy Hacker");
		
		Anonymous.CountFunction();
		
		Console.WriteLine("\nPress [Enter] to exit ...");
		Console.ReadLine();
	}
}


/*
https://github.com/takwas/niit/tree/master/faculty/faculty_projects/assignment_activity_and_exercise_files
*/
