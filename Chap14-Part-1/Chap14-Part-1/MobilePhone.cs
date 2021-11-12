using System;
using System.Collections.Generic;
using System.Text;

namespace Chap14_Part_1
{
    class MobilePhone
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        public Battery battery;
        public Screen screen;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Screen Screen
        {
            get { return this.screen; }
            set { this.screen = value; }
        }
        public MobilePhone()
            : this(null)
        {

        }

        public MobilePhone(string model)
            : this(model, null)
        {

        }

        public MobilePhone(string model, string manufacturer)
            : this(model, manufacturer, 0)
        {

        }

        public MobilePhone(string model, string manufacturer, double price)
            : this(model, manufacturer, price, null)
        {

        }
        public MobilePhone(string model, string manufacturer, double price, string owner)
            : this(model, manufacturer, price, owner, null)
        {

        }
        public MobilePhone(string model, string manufacturer, double price, string owner, Battery battery)
            : this(model, manufacturer, price, owner, battery, null)
        {

        }
        public MobilePhone(string model, string manufacturer, double price, string owner, Battery battery, Screen screen)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.screen = screen;
        }
        override public string ToString()
        {
            return ("Model: " + Model + "\nManufacturer: " + Manufacturer + "\nPrice: " + Price + "\nOwner: " + Owner + "\n" + battery.ToString() + "\n" + Screen.ToString());
        }
    }

    class Battery
    {
        private string model;
        private double idleTime;
        private double hoursTalk;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double IdleTime
        {
            get { return this.idleTime; }
            set { this.idleTime = value; }
        }

        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        public Battery()
            : this(null)
        {

        }
        public Battery(string model)
            : this(model, 0)
        {

        }
        public Battery(string model, double idleTime)
            :this(model,idleTime, 0)
        {

        }
        public Battery(string model,double idleTime, double hoursTalk)
        {
            this.model = model;
            this.idleTime = idleTime;
            this.hoursTalk = hoursTalk;
        }
        override public string ToString()
        {
            return ("Battery Model: " + Model + "\nTalk Hours: " + HoursTalk + "\nIdle Time: " + IdleTime);
        }
    }

    class Screen
    {
        private string colors;
        private string size;

        public string Colors
        {
            get { return this.colors; }
            set { this.colors = value; }
        }

        public string Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public Screen()
            : this( null)
        {

        }

        public Screen(string colors)
            :this(colors,null)
        {

        }

        public Screen(string colors, string size)
        {
            this.colors = colors;
            this.size = size;
        }
        override public string ToString()
        {
            return ("Screen Size: " + Size + "\nColors: " + Colors);
        }
    }
}
