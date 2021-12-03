using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_14_b
{
    public class PhoneCallHistoryTest
    {
        public bool GivenNewCall_AddsCallToCallHistory()
        {
            // Arrange
            Phone testPhone = new Phone("iPhone 10", "apple", 1000.00m, "Tyler");
            Call testCall = new Call(DateTime.Parse("11/12/2021 4:36 PM"), TimeSpan.FromMinutes(30));

            // Act
            testPhone.AddCall(testCall);

            // Assert
            Console.WriteLine("Given New Call, Adds Call To Call History");
            return testPhone.CallHistory.Contains(testCall);
        }

        public bool GivenANewCall_ThenRemoveCall_CallIsRemovedFromCallHistory()
        {
            // Arrange
            Phone testPhone = new Phone("iPhone 10", "apple", 1000.00m, "Tyler");
            Call testCall = new Call(DateTime.Parse("11/12/2021 4:36 PM"), TimeSpan.FromMinutes(30));
            testPhone.AddCall(testCall);

            // Act
            testPhone.DeleteCall(testCall);

            // Assert
            Console.WriteLine("Given New Call, Then Delete Call, Call Is Removed From Call History");
            return !testPhone.CallHistory.Contains(testCall);
        }

        public bool GivenTwoCallsOf50Mins_At37CentsPerMinute_Returns37Dollars()
        {
            // Arrange
            decimal expectedCost = 37.00m;
            Phone testPhone = new Phone("iPhone 10", "apple", 1000.00m, "Tyler");
            Call testCallOne = new Call(DateTime.Parse("11/12/2021 4:36 PM"), TimeSpan.FromMinutes(50));
            testPhone.AddCall(testCallOne);

            Call testCallTwo = new Call(DateTime.Parse("11/12/2021 8:36 PM"), TimeSpan.FromMinutes(50));
            testPhone.AddCall(testCallTwo);

            // Act
            decimal actualCost = testPhone.TotalCallCost(0.37m);

            // Assert
            Console.WriteLine("Given Two Calls of 50 Mins, at 37 Cents per Minute, Returns 37 Dollars");
            return actualCost == expectedCost;
        }
    }
}