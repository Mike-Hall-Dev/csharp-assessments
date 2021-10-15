using System;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide numbers separated by a space");
            string inputNums = Console.ReadLine();
            string[] splitNumStrings = inputNums.Split(' ');
            int sum = 0;

            foreach (string num in splitNumStrings)
            {
                sum += int.Parse(num);
            }

            Console.WriteLine(sum);
        }
    }
}
