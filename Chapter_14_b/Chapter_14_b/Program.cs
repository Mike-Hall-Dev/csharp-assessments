using System;

namespace Chapter_14_b
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneTest phoneTester = new PhoneTest();

            Console.WriteLine(phoneTester.GivenIphoneDetails_PrintsExpectedString());

            PhoneCallHistoryTest phoneCallHistoryTester = new PhoneCallHistoryTest();

            StudentTest studentTester = new StudentTest();

            Console.WriteLine(phoneCallHistoryTester.GivenNewCall_AddsCallToCallHistory());
            Console.WriteLine(phoneCallHistoryTester.GivenANewCall_ThenRemoveCall_CallIsRemovedFromCallHistory());
            Console.WriteLine(phoneCallHistoryTester.GivenTwoCallsOf50Mins_At37CentsPerMinute_Returns37Dollars());
            Console.WriteLine(studentTester.GivenStudentDetails_PrintString());
            Console.WriteLine(studentTester.OnStudentInstantiation_ClassCounterIncrements());

            
        }
    }
}
