using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 1, 2, 3 };

            Increment(x);

            // What will be printed to the console?
            Console.Write("The value of x is: ");
            foreach (int i in x)
            {
                Console.Write(i);
            }

            Console.Read();
        }

        static void Increment(int[] arrIn)
        {
            for (int i = 0; i < arrIn.Length; i++)
            {
                arrIn[i] = arrIn[i] + 1;
            }
        }
    }
}
