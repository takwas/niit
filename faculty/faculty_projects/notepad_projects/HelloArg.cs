

using System;


class HelloArg{
	
	public static void Main(string[] args){
		string name = args[0];
		Console.WriteLine("Hello");
		Console.WriteLine("Your name is {0}", name);
		Console.ReadLine();
	
	}
}
