using System;

namespace Chapter_9
{
    class Program
    {
        static void Main(string[] args)
        {
/*            Console.Write("Please enter a number: ");
            int numOne = int.Parse(Console.ReadLine());
            Console.Write("Pleaser enter a second number: ");
            int numTwo = int.Parse(Console.ReadLine());
            Console.Write("Please enter a third number: ");
            int numThree = int.Parse(Console.ReadLine());

            int maxNum = GetMax(numOne, numTwo,numThree);
            Console.WriteLine(maxNum + " is the max of those three numbers.");*/

            Console.Write("Please enter a number: ");
            string numForEnglish = Console.ReadLine();
            string lastNumInEnglish = GetLastNumInEnglish(numForEnglish);
            Console.WriteLine(lastNumInEnglish);

            int[] arrOne = { 1, 2, 3, 4, 5, 6 };
            int[] arrTwo = { 1, 5, 2, 3, 4, 8, 0 };
            Console.WriteLine(GetPeakNum(arrOne));
            Console.WriteLine(GetPeakNum(arrTwo));
        }

        static int GetMax(int numOne, int numTwo, int numThree)
        {
            int maxNum = Math.Max(numOne, Math.Max(numTwo,numThree));
            return maxNum;
        }

        static string GetLastNumInEnglish(string numString)
        {
            int lastNumIndex = numString.Length - 1;
            int lastNum = int.Parse(numString[lastNumIndex].ToString()); // convert last char to string to call int.parse
            string numToEnglish = "";

            switch(lastNum)
            {
                case 0: numToEnglish = "Zero"; break;
                case 1: numToEnglish = "One"; break;
                case 2: numToEnglish = "Two"; break;
                case 3: numToEnglish = "Three"; break;
                case 4: numToEnglish = "Four"; break;
                case 5: numToEnglish = "Five"; break;
                case 6: numToEnglish = "Six"; break;
                case 7: numToEnglish = "Seven"; break;
                case 8: numToEnglish = "Eight"; break;
                case 9: numToEnglish = "Nine"; break;
            }

            return numToEnglish;
        }

        static int GetPeakNum(int[] arr)
        {
            int peakNum = 0;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    peakNum = arr[i];
                    return peakNum;
                }
            }
            return -1;
        }
    }
}
