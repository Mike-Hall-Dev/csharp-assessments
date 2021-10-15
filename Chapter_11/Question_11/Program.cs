using System;

namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[] { "The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category." };
            string[] stories = new string[] { "Now I feel better.", "I managed to change.", "It made some miracle.", "I can’t believe it, but now I am feeling great.", "You should try it, too. I am very satisfied." };
            string[] firstName = new string[] { "Dayan", "Stella", "Hellen", "Kate" };
            string[] lastName = new string[] { "Johnson", "Peterson", "Charls" };
            string[] cities = new string[] { "London", "Paris", "Berlin", "New York", "Madrid" };

            Random random = new Random();

            int phrasesLength = phrases.Length;
            int storiesLength = stories.Length;
            int firstNameLength = firstName.Length;
            int lastNameLength = lastName.Length;
            int citiesLength = cities.Length;

            string result = String.Format("{0} {1} -- {2} {3}, {4}", phrases[random.Next(phrasesLength)], stories[random.Next(storiesLength)],
                              firstName[random.Next(firstNameLength)], lastName[random.Next(lastNameLength)], cities[random.Next(citiesLength)]);

            Console.WriteLine(result);
        }
    }
}
