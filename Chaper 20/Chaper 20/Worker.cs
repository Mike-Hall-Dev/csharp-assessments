using System;
using System.Collections.Generic;
using System.Text;

namespace Chaper_20
{
    class Worker : Human, IComparable<Worker>
    {
        public decimal Wage { get; set; }
        public int HoursWorked { get; set; }

        public Worker(decimal wage, int hours)
        {
            Wage = wage;
            HoursWorked = hours;
        }

        public decimal CalculateHourlyWage()
        {
            decimal result = Wage / HoursWorked;
            return result;
        }

        public int CompareTo(Worker other)
        {
            return CalculateHourlyWage().CompareTo(other.CalculateHourlyWage());
        }
    }
}
