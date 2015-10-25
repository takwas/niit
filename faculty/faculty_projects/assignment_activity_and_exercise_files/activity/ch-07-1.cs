       using System;
       namespace PrimarySchool
       {
    class DayCount
    {
        int Month;
        int Year;
        int Days;

        public DayCount() //Constructor to initialize month and year to 0
        {
            Month = 0;
            Year = 0;
        }
        //Returns 1 if year is a leap year, else returns 0
        public Boolean LeapYear()
        {
            if (Year % 4 == 0)
                return true;
            else
                return false;
        }

        //Sets the month and year
        public void setDate(int month1, int year1)
        {
            Year = year1;
            Month = month1;
        }

        // Sets the month, overloaded function
        public void setDate(int month1)
        {
            Month = month1;
            Year = 2006;
        }

        //Returns the name of the month 
        public string monthName()
        {
            switch (Month)
            {
                case 1: return "January";
                case 2: return "February";
                case 3: return "March";
                case 4: return "April";
                case 5: return "May";
                case 6: return "June";
                case 7: return "July";
                case 8: return "August";
                case 9: return "September";
                case 10: return "October";
                case 11: return "November";
                case 12: return "December";

                default: return "Invalid Month Specified!";
            }

        }
        //Sets the number of days in a month
        public void setDays()
        {
            switch (Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        Days = 31;
                        break;
                    }
                case 2:
                    {
                        Days = 28;
                        if (LeapYear())
                            Days = 29; //Assign 29 Days if leap year
                        break;
                    }
                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        Days = 30;
                        break;
                    }
            }
        }
        public void display()
        {
            string[] name = new string[25];
            setDays();
            Console.Write("The number of days in the month of " + monthName());
            Console.Write(" is " + Days);
        }

        static void Main(string[] args)
        {
            DayCount dayCount = new DayCount();
            int month, year;
            Console.WriteLine("Enter the month in number:");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year :");
            year = Convert.ToInt32(Console.ReadLine());
            dayCount.setDate(month, year);
            dayCount.display();
            Console.ReadLine();
        }
    }
}

