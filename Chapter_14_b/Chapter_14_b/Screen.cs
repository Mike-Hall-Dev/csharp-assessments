namespace Chapter_14_b
{
    public class Screen
    {
        public string Size { get; set; }
        public string Colors { get; set; }

        public Screen(string size, string colors)
        {
            this.Size = size;
            this.Colors = colors;
        }
    }
}