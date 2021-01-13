namespace Design.Pattern.BridgePattern
{
    public class BrushDemo
    {
        private Brush _brush;

        public BrushDemo(Brush brush)
        {
            this._brush = brush;
        }

        public void UseBrush()
        {
            this._brush.Paint();
        }

        public void SetColor(IColor color)
        {
            this._brush.SetColor(color);
        }

        public void SetSize(Brush brush)
        {
            this._brush = brush;
        }
    }
}
