using System;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime[] holidays = new DateTime[]
            {
                new DateTime(2021, 11, 24),
                new DateTime(2021, 12, 24),
                new DateTime(2021, 12, 25),
                new DateTime(2022, 01, 01),
                new DateTime(2022, 05, 30),
                new DateTime(2022, 07, 04),
                new DateTime(2022, 09, 05)
            };

            DateTime[] deploymentSaturdays = new DateTime[]
            {
                new DateTime(2021, 12, 11),
                new DateTime(2022, 02, 12),
                new DateTime(2022, 04, 09)
            };

            bool needUserInput = true;
            int workDays = 0;
            DateTime endDate = new DateTime();
            DateTime currentDate = DateTime.Now;

            while (needUserInput)
            {
                try
                {
                    Console.WriteLine("Enter a date to calculate how many workdays you have up to that date.");
                    Console.WriteLine("Enter (YYYY/MM/DD): ");
                    endDate = System.Convert.ToDateTime(Console.ReadLine());

                    if (currentDate > endDate)
                    {
                        Console.WriteLine("Error. Your end date cannot be before the current date.");
                        continue;
                    }
                    needUserInput = false;
                }
                catch
                {
                    Console.WriteLine("Invalid format, please enter a valid date.");
                }
            }

            while(currentDate.Date != endDate.Date)
            {
                currentDate = currentDate.AddDays(1);

                if ((currentDate.DayOfWeek >= DayOfWeek.Monday) && (currentDate.DayOfWeek <= DayOfWeek.Friday))
                    workDays++;

                foreach (var holiday in holidays)
                {
                    if (holiday.Date == currentDate.Date)
                    {
                        workDays--;
                    }
                }

                foreach (var saturday in deploymentSaturdays)
                {
                    if (saturday.Date == currentDate.Date)
                    {
                        workDays--;
                    }
                }
            }
            Console.WriteLine("There are {0} working days between now and that date", workDays);
        }
    }
}
