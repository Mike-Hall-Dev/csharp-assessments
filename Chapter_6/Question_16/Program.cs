using System;

namespace Question_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a positive number: ");
            int numFromInput = int.Parse(Console.ReadLine());

            Random random = new Random();
            int randomIndex;
            int tempIndexForSwap;

            int[] numRangeArr = new int[numFromInput];
            for (int i = 0; i < numFromInput; i++)
            {
                numRangeArr[i] = i + 1;
            }

            for (int i = 0; i < numRangeArr.Length; i++)
            {
                randomIndex = random.Next(numFromInput);

                tempIndexForSwap = numRangeArr[i];
                numRangeArr[i] = numRangeArr[randomIndex];
                numRangeArr[randomIndex] = tempIndexForSwap;
            }

            foreach (int num in numRangeArr)
            {
                Console.Write(num + " ");
            }

        }
    }

}
