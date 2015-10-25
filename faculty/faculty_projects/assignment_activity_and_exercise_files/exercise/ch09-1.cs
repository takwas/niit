using System;
using System.IO;

namespace Chap9_A1
{
    class Schedule
    {
        struct details
        {
            public DateTime Date;
            public string Appointment;
            public string Time;
            public string Day;
        };
        private details Testdetails;
        static FileStream F;
        StreamWriter W;
        StreamReader R;

        //Method to get data from the user and writing it into the file. 
        public void Getdata()
        {
            string Duedate;
            Console.Write("Appointment Date (MM/DD/YY): ");
            Duedate = Console.ReadLine();
            Testdetails.Date = Convert.ToDateTime(Duedate);
            Testdetails.Day = Convert.ToString(Testdetails.Date.DayOfWeek);
            Console.Write("Appointment with: ");
            Testdetails.Appointment = Console.ReadLine();
            Console.Write("Appointment Time: ");
            Testdetails.Time = Console.ReadLine();

            F = new FileStream("MyFile.txt", FileMode.Append, FileAccess.Write);
            W = new StreamWriter(F);

            //Writing data into the file.

            W.Write("Date: ");
            W.Write(Testdetails.Date.ToShortDateString());
            W.Write("?");
            W.Write("Day: ");
            W.Write(Testdetails.Day);
            W.Write("?");
            W.Write("Name: ");
            W.Write(Testdetails.Appointment);
            W.Write("?");
            W.Write("Time: ");
            W.Write(Testdetails.Time);
            W.WriteLine("?");

            W.Flush();
            W.Close();
        }

        //Method to display all the records from the file.
        public void Display()
        {
            string Str;
            F = new FileStream("MyFIle.txt", FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);
            Console.Clear();
            int Pos = 0;

            //Code to diplay the data on the console in a proper format.
            while ((Str = R.ReadLine()) != null)
            {
                while (true)
                {
                    Pos = Str.IndexOf("?");
                    if (Pos == -1)
                        break;
                    Console.WriteLine(Str.Substring(0, Pos));
                    Str = Str.Substring(Pos + 1);
                }
                Pos = 0;
            }
            R.Close();
        }

        //Method to search a particular record on the basis of the date.
        public void Search()
        {
            string Str, Chkstr1, Chkstr2;
            DateTime DD; int Pos;
            F = new FileStream("MyFIle.txt", FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);
            Console.Write("Enter Date (MM/DD/YY): ");
            DD = Convert.ToDateTime(Console.ReadLine());

            //Code to fetch the data from the file and diplay it on the console in a proper format.
            while ((Str = R.ReadLine()) != null)
            {
                Chkstr1 = "Date: " + DD.ToShortDateString();
                Pos = Str.IndexOf("?");
                Chkstr2 = Str.Substring(0, Pos);

                if ((Chkstr1.CompareTo(Chkstr2)) == 0)
                {
                    while (true)
                    {
                        Pos = Str.IndexOf("?");
                        if (Pos == -1)
                            break;
                        Console.WriteLine(Str.Substring(0, Pos));
                        Str = Str.Substring(Pos + 1);
                    }
                    Pos = 0;
                }
            }
            R.Close();
        }

        static void Main(string[] args)
        {
            Schedule S = new Schedule();
            int Ch = 0;
            Console.Clear();
            while (Ch != 4)
            {
                Console.WriteLine("1. Add Appointments");
                Console.WriteLine("2. View Appointments");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Exit");
                Console.Write("Enter Choice: ");
                Ch = Convert.ToInt32(Console.ReadLine());
                switch (Ch)
                {
                    case 1: Console.Clear(); S.Getdata(); Console.Clear(); break;
                    case 2: Console.Clear(); S.Display(); Console.ReadLine(); Console.Clear(); break;
                    case 3: Console.Clear(); S.Search(); Console.ReadLine(); Console.Clear(); break;
                    case 4: return;
                    default: Console.WriteLine("Invalid input."); break;
                }
            }
            Console.ReadLine();
        }
    }

}
