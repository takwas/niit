using System;
namespace FFC
{
        public abstract class Furniture
    {
        protected string color;
        protected int width;
        protected int height;
            public abstract void Accept();
            public abstract void Display();
    }

    class Bookshelf : Furniture
    {
        private int numOf_shelves;
        public override void Accept()
        {
            string str2, str3, str4;
            Console.WriteLine("ENTER VALUES FOR BOOKSHELF");
            Console.WriteLine("Enter Color ");

            color = Console.ReadLine();
            Console.WriteLine("Enter Width ");
            str2 = Console.ReadLine();
            width = Convert.ToInt32(str2);
            Console.WriteLine("Enter Height ");
            str3 = Console.ReadLine();
            height = Convert.ToInt32(str3);
            Console.WriteLine("Enter No. of shelves ");
            str4 = Console.ReadLine();
            numOf_shelves = Convert.ToInt32(str4);
        }
        public override void Display()
        {
            Console.WriteLine("DISPLAYING VALUES FOR BOOKSHELF");
            Console.WriteLine("Color is {0}", color);
            Console.WriteLine("Width is {0}", width);
            Console.WriteLine("Height is {0}", height);
            Console.WriteLine("Number of shelves is {0}", numOf_shelves);
        }
    }

    class Chair : Furniture
    {
        private int numOf_legs;
        public override void Accept()
        {

            string str2, str3, str4;
            Console.WriteLine("ENTER VALUES FOR CHAIR");
            Console.WriteLine("Enter Color ");

            color = Console.ReadLine();
            Console.WriteLine("Enter Width ");
            str2 = Console.ReadLine();
            width = Convert.ToInt32(str2);
            Console.WriteLine("Enter Height ");
            str3 = Console.ReadLine();
            height = Convert.ToInt32(str3);
            Console.WriteLine("Enter No. of legs in a chair ");
            str4 = Console.ReadLine();
            numOf_legs = Convert.ToInt32(str4);
        }
        public override void Display()
        {
            Console.WriteLine("DISPLAYING VALUES FOR CHAIR");
            Console.WriteLine("Color is {0}", color);
            Console.WriteLine("Width is {0}", width);
            Console.WriteLine("Height is {0}", height);
            Console.WriteLine("Number of legs is {0}", numOf_legs);

        }
    }
    class BookShelfChair
    {
        static int Main(string[] args)
        {
            Bookshelf b1 = new Bookshelf();
            Chair c1 = new Chair();
            b1.Accept();
            b1.Display();
            c1.Accept();
            c1.Display();
            Console.ReadLine();
            return 0;
        }
    }

}

