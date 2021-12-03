using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_App
{
    class Hotel
    {
        public string Name { get; set; }
        public string City { get; set; }

        public int Rooms { get; set; }
        public List<Reservation> Reservations { get; set; }

        public Hotel(string name, string city, int rooms)
        {
            this.Name = name;
            this.City = city;
            this.Rooms = rooms;
            this.Reservations = new List<Reservation>();
        }
    }
}
