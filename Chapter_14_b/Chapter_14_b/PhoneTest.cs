using System;

namespace Chapter_14_b
{
    public class PhoneTest
    {
        public bool GivenIphoneDetails_PrintsExpectedString()
        {
            // Arrange
            Phone testPhone = new Phone("iPhone 10", "Apple", 1000.00m, "John");

            // Act
            string actualString = testPhone.ToString();

            // Assert           
            //Phone.PrintNokiaN95();
            Console.WriteLine("Given iPhone Details, Prints Expected String");
            return actualString == "Apple iPhone 10 for $1000.00 owned by John.";
            
        }
    }
}