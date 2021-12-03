using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter_16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            List<int> testList = buildIntegerList();
                        Console.WriteLine(testList.Sum());*/

            //int[] test = { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            //findMajorant(test);

            //countOccurancesInArray(test);

            List<int> test2 = new List<int>(){ 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6 };

            removeOddOccurances(test2);
        }

        public static List<int> buildIntegerList()
        {
            List<int> intList = new List<int>();

            while (true)
            {
                Console.WriteLine("Please enter a positive intger: ");
                string userInput = Console.ReadLine();
                if (userInput == "") break;
                int num = 0;
                try
                {
                    num = int.Parse(userInput);
                    if (num < 0)
                    {
                        Console.WriteLine("Please enter a positive integer");
                        continue;
                    }
                    intList.Add(num);
                }
                catch
                {
                    Console.WriteLine("Please enter only positive integers.");
                }
            }
            return intList;           
        }

        public static void findMajorant(int[] arr)
        {
            List<int> listArray = new List<int>(arr);
            listArray.Sort();
            int N = listArray.Count;

            bool found = false;
            int counter;

            for (int i = 0; i < listArray.Count; i = i + counter)
            {
                counter = 1;

                for (int j = i + 1; j < listArray.Count; j++)
                {
                    if (listArray[i].Equals(listArray[j]))
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                    if (counter >= (N / 2) + 1)
                    {
                        Console.WriteLine("{0} is a majorant", listArray[i]);
                        found = true;
                    }
                }
            }
            if (found != true)
            {
                Console.WriteLine("The majorant does not exist!");
            }
        }

        static void countOccurancesInArray(int[] arr)
        {
            Array.Sort(arr);
            int lastNumber = -1;
            foreach (int number in arr)
            {
                if (number != lastNumber)
                {
                    Console.Write("| {0} -> {1} times ", number, arr.Count(currNum => currNum == number));
                }
                lastNumber = number;
            }
            Console.Write("|");
        }

        static void removeOddOccurances(List<int> numList)
        {
            Dictionary<int,int> numDict = new Dictionary<int, int>();

            foreach (int num in numList)
            {
                if (!numDict.ContainsKey(num))
                {
                    numDict.Add(num, 1);
                }
                else
                {
                    numDict[num] += 1;
                }
            }

            foreach (KeyValuePair<int, int> entry in numDict)
            {
                Console.WriteLine(entry.Key + " : " + entry.Value);
            }
            for (int i = 0; i < numList.Count; i++)
            {
                if (numDict[numList[i]] % 2 != 0)
                {
                    numList.Remove(numList[i]);
                    i--;
                }
            }

            foreach (int num in numList) Console.WriteLine(num);
        }
    }
}
