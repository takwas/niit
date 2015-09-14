using System;

class Calc
{

	// Add method
	static void Add(int n1, int n2)
	{
		int result = n1 + n2;
		Console.WriteLine("Result: of {0} + {1} is {2}", n1, n2, result);
	}
	
	//
	/*
	void AcceptDetails()
	{
	}
	*/
	// Subtract
	static void Sub(int n1, int n2)
	{
		int result = n1 - n2;
		Console.WriteLine("Result: of {0} - {1} is {2}", n1, n2, result);				
	}

	public static void Main(string[] args)
	{
		string operatoro = "";
		string strnum1 = "";
		string strnum2 = "";
		
		int num1;
		int num2;
		
		Console.WriteLine("MMS Calc running...\n");
		Console.Write("Enter first value:  ");   //notice the "Console.Write" and not Console.Write;ine
		strnum1 = Console.ReadLine();//value accepted as a string
		num1 = Convert.ToInt32(strnum1);// value converted to an integer: e.g "10" nbecomes 10; notice the inverted commas have been taken out
		
		Console.Write("Enter second value:  ");
		strnum2 = Console.ReadLine();
		num2 = Convert.ToInt32(strnum2);
		
		Console.Write("Choose operator from ('+', '-', '/', 'x'):  "); // options giver
		operatoro = Console.ReadLine();
		
		switch(operatoro)
		{
			case "+":
				Add(num1, num2);
				break;
			case "-":
				Sub(num1, num2);
				break;
			default:
				Console.WriteLine("You entered a wrong operator.");
				break;
		}
		
	}

}