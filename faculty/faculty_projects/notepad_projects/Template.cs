

///functional / procedural prog

using System;

class ProcedureDemo
{
	//Procedure 1
	// calls Procedure2()
	static void Procedure1()
	{
		//do something
		Procedure2();
	}
	
	//Procedure2()
	static void Procedure2()
	{
		//do something
	}


	// Main method
	static void Main(string[] args)
	{
		Procedure1();	
	}
}
