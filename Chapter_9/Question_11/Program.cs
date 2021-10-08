using System;

namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice = 0;

            do
            {
                Console.WriteLine("Hello please choose one of the options below.");
                Console.WriteLine("1: Reverse a Number");
                Console.WriteLine("2: Calculate Average");
                Console.WriteLine("3: Solve Linear Equation");
                Console.WriteLine("4: Quit");
                Console.WriteLine();
                Console.Write("Your Choice: ");

                string userInput = Console.ReadLine();
                bool validInput = Int32.TryParse(userInput, out userChoice);

                if (!validInput)
                {
                    Console.WriteLine("Please enter a valid choice.");
                    Console.WriteLine("Press any key to continue.");
                    Console.Read();
                    continue;
                }
             
                switch (userChoice)
                {
                    case 1:
                        Console.Write("Please select a number between 1 and 50,000,000: ");
                        int userNum = int.Parse(Console.ReadLine());
                        Console.WriteLine(ReverseNum(userNum));
                        break;
                    default:
                        Console.WriteLine("Not a valid choice");
                        break;
                }
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
            } while (userChoice != 4);     
        }

        static int ReverseNum(int num)
        {
            string numString = num.ToString();
            string reversedNumString = "";
            int lastIndex = numString.Length - 1;
            int reversedNum;

            while (lastIndex >= 0)
            {
                reversedNumString += numString[lastIndex];
                lastIndex--;
            }

            reversedNum = int.Parse(reversedNumString);
            return reversedNum;
        }
    }
}
