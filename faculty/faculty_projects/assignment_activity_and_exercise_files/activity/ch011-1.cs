/*Program to play Hangman game. The program asks a user to
enter a category as Book/Movie. Based on the category provided, 
a book name or category name is extracted and the user is asked to 
guess the name by giving the character and its position.*/

using System;
using System.IO;
using System.Threading;
namespace Game
{

    public class Hangman
    {
        string randomString, userString;
        int dataLength;
        string Category;
        string[] bookData = new string[5];
        string[] movieData = new string[5];
        int bookCount = 0, movieCount = 0;
        public Hangman()
        {
            FillNameValues();
        }

        // Stores the movie names and Book names in respective strings
        private void FillNameValues()
        {
            //Declaring the variables

            string firstLine;
            // open the file for reading
            StreamReader sRead = new StreamReader("c:\\TextTest.txt");
            sRead.BaseStream.Seek(0, SeekOrigin.Begin);
            //Reading the content of the file
            firstLine = sRead.ReadLine();
            while (firstLine != null)
            {
                //Storing the Book names in the BookData array
                if (firstLine.Substring(0, 1) == "B")
                {
                    int stringStartPos = firstLine.IndexOf(':');
                    bookData[bookCount] = firstLine.Substring(stringStartPos + 1);
                    bookCount++;

                }
                //Storing the Movie names in the MovieData array
                else
                {
                    int stringStartPos = firstLine.IndexOf(':');
                    movieData[movieCount] = firstLine.Substring(stringStartPos + 1);
                    movieCount++;

                }
                firstLine = sRead.ReadLine();

            }
        }

        public int AcceptCategory()
        {
            //Accepting the choice of the user in terms of the Category 
            Console.WriteLine("Enter the Category to Play - Book/Movie");
            Category = Console.ReadLine();
            Category = Category.ToUpper();

            if (Category != "BOOK" && Category != "MOVIE")
            {
                Console.WriteLine("Invalid Category....\n");
                return 0;
            }
            else
            {
                ExtractName();
                return 1;
            }
        }


        public void ExtractName()
        {
            //Creating the object of the Random class
            Random RandGen = new Random();
            if (Category == "BOOK")
            {//Randomly selecting the Book name from the array
                int Rnd = RandGen.Next(0, bookCount - 1);
                //Calling the play method
                randomString = bookData[Rnd];
            }
            else
            {//Randomly selecting the Movie name from the array
                int Rnd = RandGen.Next(0, movieCount - 1);
                //Calling the Startplay method
                randomString = movieData[Rnd];
            }

        }


        /*This method will allow the user to give the characters and 
        displaying his status as to WON or LOST */
        public void StartGame()
        {
            //Calculating the length of movie/book name
            dataLength = randomString.Length;

            //Declaring Variables
            char locateChar;
            int correctCnt = 0, inCorrectCnt = 0;
            int i, k;
            //Decalring string to store user input
            char[] s = new char[randomString.Length];
            //Loop to accept the characters and its positions
            //Loop allows user to attempt 2 times more than the total characters
            InitializeUserString();
            ShowUserInputString();
            if (Category == "BOOK")
            {
                Console.WriteLine("The total number of characters in the Book: {0}", randomString.Length);
                Console.WriteLine("The total number of characters you can enter to guess the name of Book: {0}", randomString.Length + 2);
            }
            else
            {
                Console.WriteLine("The total number of characters in the Movie: {0}", randomString.Length);
                Console.WriteLine("The total number of characters you can enter to guess the name of Movie: {0}", randomString.Length + 2);
            }
            for (i = 1, k = 0; i <= dataLength + 2 || k == dataLength; i++)
            {
                if (correctCnt == dataLength || inCorrectCnt == dataLength)
                    break;
                Console.WriteLine("Enter the char ");
                locateChar = Convert.ToChar(Console.ReadLine().ToLower());
                int foundPos = 0;
                int foundChar = 0;
                // To extract each character of a string
                foreach (char c in randomString)
                {
                    if (c == locateChar)
                    {
                        UpdateString(foundPos, locateChar.ToString());
                        k++;
                        foundChar = 1;
                    }
                    foundPos++;
                }

                if (foundChar == 0)
                {
                    Console.WriteLine("Wrong Attempt...Better Luck Next Time!!\n\n");
                    inCorrectCnt++;
                }
                else
                {
                    correctCnt++;
                }
                ShowUserInputString();
                Console.WriteLine("Total Correct Attempts: {0}\t", correctCnt);
                Console.WriteLine("Total Incorrect Attempts: {0}\n", inCorrectCnt);
                if (k == dataLength)
                    break;

            }

            if (randomString==userString)
            {
                Console.WriteLine("You have Won \n");
            }
            else
            {
                Console.WriteLine("The Correct name is {0}", randomString);
                Console.WriteLine("You have lost \n");
            }
        }
        private void UpdateString(int fPos, string updateStr)
        {
            string beforeString, afterString;
            if (fPos != 0 && fPos != dataLength - 1)
            {
                if (fPos == 1)
                    beforeString = userString.Substring(0, 1);
                else
                    beforeString = userString.Substring(0, fPos);
                afterString = userString.Substring(fPos + 1, dataLength - (fPos + 1));
                userString = beforeString + updateStr + afterString;
            }
            if (fPos == 0)
            {
                afterString = userString.Substring(fPos + 1, dataLength - (fPos + 1));
                userString = updateStr + afterString;
            }
            if (fPos == dataLength - 1)
            {
                beforeString = userString.Substring(0, fPos);
                userString = beforeString + updateStr;
            }
        }




        public void InitializeUserString()
        {
            userString = "           ";
            for (int i = 0; i < dataLength; i++)
            {

                userString = userString.Insert(i, "*");
            }


        }

        public void ShowUserInputString()
        {
            Console.Clear();
            Console.WriteLine("Input Value: {0} \n\n", userString);
        }
    }
    class Game
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("You have to complete the game within 60 seconds");
            Hangman obj = new Hangman();
            int returnVal = obj.AcceptCategory();
            if (returnVal == 1)
            {

                //obj.StartGame();
                Thread t = new Thread(new ThreadStart(obj.StartGame));
                t.Start();//Starting the new thread
                Thread.Sleep(60000);//Making the Main thread sleep for 90 Seconds
                try 
                {
                    t.Abort();
                    Console.WriteLine("Time Over");
                }//Killing the new thread
                catch (ThreadAbortException e) { Console.WriteLine(e.Message); }

            }
            
            Console.ReadLine();

        }
    }
}
