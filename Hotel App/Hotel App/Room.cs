using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_App
{
    enum RoomType
    {
        Single,Double,Queen,King
    }
    class Room
    {
        public int Number { get; set; }
        public double Cost { get; set; }
        public RoomType Type { get; set; }
    }
}
