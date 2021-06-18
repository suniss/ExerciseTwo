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
            while (DisplayMenu)
            {
                Console.Clear();
                Console.WriteLine("Welcome to main menu:)");
                Console.WriteLine("Please Enter your choice from 0-3");
                Console.WriteLine("Enter 1 to get price movie ticket"); // to get difference price
                Console.WriteLine("Enter 2 to print ten times");
                Console.WriteLine("Enter 3 to find the third word");
                Console.WriteLine("Enter 0 to exit menu");
                string input = Console.ReadLine();
                switch (input)
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
            Console.Clear();
            Console.WriteLine("This program will print out your movie ticket price");
            Console.Write("Number of person to buy:");
            uint number; // number of person to buy
            int total = 0;
            string input;
            byte age; //get age 
            if (UInt32.TryParse(Console.ReadLine(), out number))
            {
                for (int i = 0; i < number; i++)
                {
                    Console.Write("Please enter the age of person" + (i + 1).ToString() + " ");
                    input = Console.ReadLine();
                    if (!Byte.TryParse(input, out age))
                    {
                        Console.WriteLine("Invalid age, please try again");
                        i--;
                    }
                    else
                        total += Price(age);

                }
                Console.WriteLine("-----Total price--------");
                Console.WriteLine("{0:C}", total);
            }
            else
                Console.WriteLine("Incorrect number of persons");
            Console.ReadLine();
        }
    
        private static void PrintString() // Print string ten times
        {
            Console.Clear();
            Console.WriteLine("This menu will print out your input for ten times");
            Console.Write("Please write your string input");
            string input = Console.ReadLine();
            string output = null;
            for (int i = 0; i < 10; i++)
            {
                output += (i + 1).ToString() + "." + input + ", ";
            }
            output = output.Substring(0, output.Length - 2);
            Console.WriteLine(output);
            Console.ReadLine();
        }
        private static void FindThirdWord()
        {
            Console.Clear();
            Console.WriteLine("Please enter string with minimum 3 words:");
            string input = Console.ReadLine();
            input = input.Trim();

            // split string to seperate word
            char[] delimiterChars = new char[] { ' ', ',', '.', ':', '\t', ';' };
            string[] array = input.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

            while (array.Length < 3)
            {
                Console.WriteLine("Your input is less than 3 words, please try again");
                input = Console.ReadLine();
                array = input.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            }
                Console.WriteLine("The third words is:" + array[2]);
                Console.ReadLine();
            }
        private static int Price(byte age)
        {
            int price = 0;
            if(age <= 2 || age > 100)
            {
                Console.WriteLine("Free ticket");
                price = 0;
            }
            else if (age < 20)
            {
                Console.WriteLine("Kids price: 80kr");
                price = 80;

            }
            else if (age > 64)
            {
                Console.WriteLine("Senior Discount: 90kr");
                 price = 90;
            }
            else
            {
                Console.WriteLine("Standard price: 120kr");
                price = 120;
            }
            return price;
        }
        }
        
    }

