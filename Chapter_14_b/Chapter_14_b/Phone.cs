using System;
using System.Collections.Generic;

namespace Chapter_14_b
{
    public class Phone
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string Owner { get; set; }
        public Battery Battery { get; set; }
        public Screen Screen { get; set; }
        public List<Call> CallHistory { get; set; }

        private static Phone nokiaN95 = new Phone("nokiaN95", "Nokia", 200m);

        public Phone(string model, string manufacturer, decimal price,
            string owner = null, Battery battery = null, Screen screen = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Screen = screen;

            this.CallHistory = new List<Call>();
        }

        public static void PrintNokiaN95()
        {
            Console.WriteLine($"{nokiaN95.Model},{nokiaN95.Manufacturer}, {nokiaN95.Price}");
        }

        public override string ToString()
        {
            return $"{Manufacturer} {Model} for ${Price} owned by {Owner}.";
        }

        public void AddCall(Call newCall)
        {
            CallHistory.Add(newCall);
        }

        public void DeleteCall(Call callToDelete)
        {
            CallHistory.Remove(callToDelete);
        }

        public decimal TotalCallCost(decimal costPerMinute)
        {
            decimal totalMinutes = 0.00m;

            foreach (Call call in CallHistory)
            {
                totalMinutes += (decimal)call.Duration.TotalMinutes;
            }

            decimal cost = totalMinutes * costPerMinute;
            return cost;
        }
    }
}