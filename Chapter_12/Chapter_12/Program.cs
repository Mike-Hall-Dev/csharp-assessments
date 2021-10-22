using System;
using System.IO;
using System.Net;

namespace Chapter_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //QuestionSeven();
            //QuestionEight(0, 100);
            //QuestionNine(@"C:\Users\Mike.Hall\Documents\c#_repos\Assessments\csharp-assessments\Chapter_12\Chapter_12\test.txt");

            string urlOne = "https://introprogramming.info/wp-content/uploads/2017/08/csharp-book-nakov-en-v2013-cover.jpg";
            string urlTwo = "http://introprogramming.info/wp-content/themes/introprograming_en/images/Intro-Csharp-Book-front-cover-big_en.png";
            QuestionThirteen(urlOne);
            QuestionThirteen(urlTwo);
        }

        static void QuestionSeven()
        {
            
            try
            {
                Console.WriteLine("Pleaser enter a positive integer: ");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput < 0) throw new Exception();

                Console.WriteLine(Math.Sqrt(userInput));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input.");
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
        static void QuestionEight(int start, int end)
        {
            int currentNum = start;

            for (int i = 10; 0 <= i; i--)
            {
                try
                {
                    Console.WriteLine("Please enter {0} more numbers between {1} and {2}, each number " +
                        "must be greater than the last.", i, start, end);
                    int userInput = int.Parse(Console.ReadLine());

                    if ((userInput <= start) || (userInput >= end))
                    {
                        throw new ArgumentOutOfRangeException(string.Format("Please insert a number within the range of {0} and {1}.", start, end));
                    }

                    if (userInput <= currentNum) throw new ArgumentException("Please enter a number greater than the previous.");

                    currentNum = userInput;

                }
                catch (FormatException)
                {
                    i--;
                    Console.WriteLine("Incorrect input, please insert a number.");
                }
                catch (ArgumentOutOfRangeException err)
                {
                    i--;
                    Console.WriteLine(err.Message);
                }

                catch (ArgumentException err)
                {
                    i--;
                    Console.WriteLine(err.Message);
                }
            }
        }

        static void QuestionNine(string path)
        {
            try
            {
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine(string.Format("No file found {0}", path));
            }
            catch (IOException)
            {
                Console.WriteLine("Bad file.");
            }
        }

        static void QuestionThirteen(string address)
        {
            try
            {
                Uri addressUri = new Uri(address);
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(addressUri, @"C:\Users\Mike.Hall\Desktop\test.jpg");
                    Console.WriteLine("Downloading...");
                    Console.WriteLine("Success!");
                }
            }
            catch (WebException)
            {
                Console.WriteLine("Please try again The file was not found or the url is bad.");
            }
        }
    }
}
