using System;
class Interchange
{
   private
      int Top_score=5;
      int New_score=10;
      int Temp;

   public void Swap()
      {   
          
		
	      Console.WriteLine("The value of Top score is:");
		  Console.WriteLine(Top_score);	
	      Console.WriteLine("The value of New score is:");
	      Console.WriteLine(New_score);
          Temp=Top_score;   
          Top_score=New_score;
          New_score=Temp;
      }
      public void Display()
      {   
          Console.WriteLine("The new value of Top score is:");
	      Console.WriteLine(Top_score);
		  Console.WriteLine("The previous Top score was:");
		  Console.WriteLine(New_score);
       }

}

class MyInterchange
 {   
        
	public static void Main(string[] args)
	{   
    	Interchange I1= new Interchange();   
    	I1.Swap();   
    	I1.Display();
    	Console.ReadLine();
   
	}
}
