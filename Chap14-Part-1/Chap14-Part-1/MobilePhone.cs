using System;
using System.Collections.Generic;
using System.Text;

namespace Chap14_Part_1
{
    class MobilePhone
    {
        private string model = null;
        private string manufacturer = null;
        private double price = 0;
        private string owner = null;
        public Battery battery;
        public Screen screen;

        public MobilePhone()
        {

        }
    }

    class Battery
    {
        private string model;
        private double idletTime;
        private double hoursTalk;
    }

    class Screen
    {
        private int colors;
        private string size;
    }
}
