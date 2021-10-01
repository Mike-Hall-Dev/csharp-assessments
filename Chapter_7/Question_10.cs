using System;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 4, 1, 1, 4, 2, 3, 4, 4, 4, 1, 2, 4, 9, 3 };
            int count = 1;
            int tempCount, currentNum;
            int mode = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                currentNum = array[i];
                tempCount = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (currentNum == array[j])
                    {
                        tempCount += 1;
                    }
                }
                if (tempCount > count)
                {
                    mode = currentNum;
                    count = tempCount;
                }
            }
            Console.WriteLine("The mode is {0} ({1} times)", mode, count);
       
        }
    }
}
