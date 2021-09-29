using System;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number between 1 and 20: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0 && n < 21)
            {
                for (int row = 1; row <= n; row++)
                {
                    for (int col = row; col < row + n; col++)
                    {
                        Console.Write(col + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("This number is out of the specified range.");
            }
        }
    }
}
