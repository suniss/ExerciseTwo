using System;

namespace ExerciseTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMunu(); 
        }
        public static void MainMunu()
        {
            // display menu for user to choose
            bool DisplayMenu = true;
            while(DisplayMenu)
            {
                Console.Clear();
                Console.WriteLine("Welcome to main menu:)");
                Console.WriteLine("Please Enter your choice from 0-3");
                Console.WriteLine("Enter 1 to get price movie ticket"); // to get difference price
                Console.WriteLine("Enter 2 to print ten times");
                Console.WriteLine("Enter 3 to find the third word");
                Console.WriteLine("Enter 0 to exit menu");
                string input = Console.ReadLine();
                switch(input)
                {
                    case "0":
                        DisplayMenu = false;
                        break;
                    case "1":
                        MovieTicket();
                        DisplayMenu = true;
                        break;
                    case "2":
                        PrintString();
                        DisplayMenu = true;
                        break;
                    case "3":
                        FindThirdWord();
                        DisplayMenu = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect, Please choose again");
                        Console.ReadLine();
                        DisplayMenu = true;
                        break;
                }
            }
        }

        private static void MovieTicket()
        {

        }
        private static void PrintString()
        {

        }
        private static void FindThirdWord()
        {
            Console.WriteLine("Please enter string with minimum 3 words:");
            string input = Console.ReadLine();

            // split string to seperate word
            char[] delimiterChars = new char[] { };
            string[] array = input.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            
            while (array.Length < 3)
            {
               
            }
        }
        
    }
}
