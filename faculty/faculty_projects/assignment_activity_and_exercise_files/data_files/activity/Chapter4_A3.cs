using System;


    public class FunctionCount
    {
        public static int count = 0;
        public static void CountFunction()
        {
            count++;
            System.Console.WriteLine("Count function is Called by Main {0} times.", count);
        }
        public static void Main(string[] args)
        {
            for (int var = 0; var < 10; var++)
            {
                FunctionCount.CountFunction();
            }

            Console.ReadLine();
        }
        
    }
