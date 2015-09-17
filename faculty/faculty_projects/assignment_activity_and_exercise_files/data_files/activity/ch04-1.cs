using System;

    class Area
    {
        static int Result;
        public static void AreaRec()
        {
            int Length,Breadth;
            
            Console.WriteLine("Enter the Length of Rectangle");
            Length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Breadth of Rectangle");
            Breadth = Convert.ToInt32(Console.ReadLine());

            Result = Length*Breadth;
            Console.WriteLine("The Area of Rectangle is{0}",Result);

        }
        public static void AreaSqu()
        {
            int Side;
           Console.WriteLine("Enter the Side of the Square");
           Side = Convert.ToInt32(Console.ReadLine());

            Result = Side *Side ;
            Console.WriteLine("The Area of Square is{0}",Result);
        }
        
        static void Main(string[] args)
        {
            
            int Option;
            
            Console.WriteLine("Main Menu");
            Console.WriteLine("1.Area of Rectangle");
            Console.WriteLine("2.Area of Square");
            

            Console.WriteLine("Enter your choice (1, 2)");
            Option = Convert.ToInt32(Console.ReadLine());

            switch (Option)
            {
                case 1:
                    AreaRec();
                    break;
                case 2:
                    AreaSqu();
                    break;
                default:
	  		Console.WriteLine("Incorrect Choice");
      		break;
               
            }


            Console.ReadLine();

        }


    }
