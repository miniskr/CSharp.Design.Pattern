namespace Design.Pattern.BridgePattern
{
    public interface IColor
    {
        public string Color { get; }
    }

    public class BlueColor : IColor
    {
        public string Color { get; }

        public BlueColor()
        {
            this.Color = "Blue";
        }
    }

    public class RedColor : IColor
    {
        public string Color { get; }

        public RedColor()
        {
            this.Color = "Red";
        }
    }

    public class YellowColor : IColor
    {
        public string Color { get; }
        public YellowColor()
        {
            this.Color = "Yellow";
        }
    }
}
