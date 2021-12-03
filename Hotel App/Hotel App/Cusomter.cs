using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_App
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CreditCardNumber { get; set; }

        public Customer(string first, string last, string phone, DateTime dob, string cc)
        {
            this.FirstName = first;
            this.LastName = last;
            this.PhoneNumber = phone;
            this.DateOfBirth = dob;
            this.CreditCardNumber = cc;
        }
    }
}
