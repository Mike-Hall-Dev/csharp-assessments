namespace Chapter_14_b
{
    public class Battery
    {
        public string Model { get; set; }
        public decimal IdleTime { get; set; }
        public decimal HoursTalk { get; set; }
        public BatteryType Battery_Type { get; set; }

        public Battery(string model, decimal idleTime, decimal hoursTalk, BatteryType batteryType = BatteryType.LiIon)
        {
            this.Model = model;
            this.IdleTime = idleTime;
            this.HoursTalk = hoursTalk;
            this.Battery_Type = batteryType;
        }

        public Battery(decimal idleTime, decimal hoursTalk) : this(null, idleTime, hoursTalk)
        {
        }

        public enum BatteryType
        {
            LiIon = 1, NiMH = 2, NiCd = 3
        }
    }
}