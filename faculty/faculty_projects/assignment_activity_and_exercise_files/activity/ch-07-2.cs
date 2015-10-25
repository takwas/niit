using System;
namespace FunCityLand
{
    class Distance
    {
        internal int Length;
        public Distance()
        {
            Length = 0;
        }
        public static Distance operator +(Distance Distance1, int
        Value)
        {
            Distance1.Length += Value;
            return Distance1;
        }
        public void DisplayDistance(Distance Distance2, int Length)
        {
            Distance Result;
            Console.WriteLine("The distance travelled is {0}", 
            Distance2.Length);
            Console.WriteLine("The remaining distance to reach the
            destination is {0}", Length);
            Result = Distance2 + Length;
            Console.WriteLine("The total distance you have to
            travel is {0}", Result.Length);
        }

    }
    class EntryPoint
    {
        public static void Main()
        {
            Distance Distance1 = new Distance();
            Distance Distance2 = new Distance();

            string Location;
            int TravelledDistance;
            Console.WriteLine("Enter the Location you have reached:
            A, B, C ");
            Location = Console.ReadLine().ToUpper();
            if (Location == "A" || Location == "B" || Location == 
            "C")
            {
                Console.WriteLine("Enter the distance you have
                covered: ");
                TravelledDistance =
                Convert.ToInt32(Console.ReadLine());
                Distance2.Length = TravelledDistance;
                switch (Location)
                {
                    case "A":
                        Distance1.DisplayDistance(Distance2, 15);
                            break;
                        case "B":
                            Distance1.DisplayDistance(Distance2,
                            20);
                            break;
                        case "C":
                            Distance1.DisplayDistance(Distance2, 
                            25);
                            break;
                        default:
                            Console.WriteLine("The Location cannot 
                            be found");
                            break;
                }
            }
            else
                Console.WriteLine("Incorrect Value");
            Console.ReadLine();
        }
    }
}
