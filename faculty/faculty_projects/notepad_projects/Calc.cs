//author: ac3Takwas
//date: 14-09-2015
using System;

class Calc
{

	/* Add method
	 *
	 * This method (or function) will add its
	 * parameters n1 and n2. The values for
	 * these parameters will be assigned when
	 * the function is called later on.
	 *
	 * Note that 'to call' a function means to
	 * actually use the function. Here we are just
	 * 'defining' or creating the function.
	 *
	 * On the first line, a variable "result"
	 * is created to hold the sum of variables "n1" and "n2".
	 *
	 * On the second line, the arithmetic operation is
	 * carried out and the resulting value is
	 * assigned to variable "result".
	 */
	static void Add(int n1, int n2)
	{
		int result;
		result = n1 + n2;
		Console.WriteLine("\n\tResult: of {0} + {1} is {2}", n1, n2, result);
	}
	
	/* Subtract method
	 *
	 * This method (or function) will subtract its
	 * second parameter "n2" from the first "n1". The values for
	 * these parameters will be assigned when
	 * the function is called later on.
	 *
	 * Note that 'to call' a function means to
	 * actually use the function. Here we are just
	 * 'defining' or creating the function.
	 *
	 * On the first line, a variable "result"
	 * is created to hold the difference between
	 * the variables "n1" and "n2".
	 *
	 * On the second line, the arithmetic operation is
	 * carried out and the resulting value is
	 * assigned to variable "result".
	 */
	static void Subtract(int n1, int n2)
	{
		int result;
		result = n1 - n2;
		Console.WriteLine("\n\tResult: of {0} - {1} is {2}", n1, n2, result);				
	}
	
	
	//****************************************//
	//**	ASSIGNMENT:							***//
	//**	IMPLEMENT CODE FOR THE		***//
	//**	REMAINING FUNCTIONS/METHODS*//
	//**	BLOCK HERE.							***//							
	//**	Multiply(); Divide(); and 			***//
	//**	Find_Remainder() 					***//
	//****************************************//


	public static void Main(string[] args)
	{
		// Declaring string type variables to accept input from our user
		string arith_operator = "";
		string strnum1 = "";
		string strnum2 = "";
		
		// Declaring integer type variables to hold the integer forms of the user's input after conversion
		int num1;
		int num2;
	
		
		// Print some user friendly messages to the user
		Console.WriteLine("\n\nProgram running ...\n");
		Console.WriteLine("========== MMS-SE .NET Calc ==========");

		// Begin accepting values from the user
		Console.Write("\tEnter first value:\t\t\t");   		// notice I used "Console.Write" and not "Console.WriteLine"
		strnum1 = Console.ReadLine();					// user value accepted as a string and stored in variable "strnum1"
		num1 = Convert.ToInt32(strnum1);				// user value converted to an integer and stored in variable "num1"	
		// After conversion a string value such as "10" becomes an integer value like 10; notice the inverted commas -- " " -- have been taken out
		
		// Accept second value from user; the steps are similar to the ones above
		Console.Write("\tEnter second value:\t\t\t");
		strnum2 = Console.ReadLine();
		num2 = Convert.ToInt32(strnum2);
		
		// Accept choice of arithmetic operator from user
		Console.Write("\tChoose operator...\n\t(' + ', ' - ', ' / ', ' x ', ' % '):\t");		// the options in bracket will make it easier for the user to make a choice
		arith_operator = Console.ReadLine();		// user option accepted as a string and stored in variable "arith_operator"
		

		/* Conditional block (Switch-Case block)
		 *
		 * The case that matches the value of variable "arith_operator"
		 * would be executed and the switch-case operation would end
		 * 
		 * If no case matches it, the "default" case is executed
		 * and the switch-case operation would end
		 */
		switch(arith_operator)
		{
			case "+":
				/* If the user chose a 'plus', then the instructions here are executed
				 * 
				 * Here we call the Add function which we created
				 * above (outside this main method)
				 *
				 * We pass in the two required values using
				 * variables "num1" and "num2"
				 */
				Add(num1, num2);
				break;									// every case block should always end with a break statement						
			
			
			case "-":
				/* If the user chose a 'minus', then the instructions here are executed instead
				 */
				Subtract(num1, num2);				// call the Subtract function created above
				break;									// every case block should always end with a break statement
			
			//****************************************//
			//**	ASSIGNMENT:							***//
			//**	IMPLEMENT CODE FOR THE		***//
			//**	REMAINING CASE BLOCK HERE	***//
			//****************************************//

			default:
				/* default block gets executed if no case is matched
				 */
				Console.WriteLine("\nYou chose an invalid operator.\nExiting ...");
				break;
		}
		
	}

}
