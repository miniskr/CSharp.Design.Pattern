using System;

namespace Design.Pattern.BridgePattern
{
    public abstract class Brush
    {
        protected IColor color;

        public Brush(IColor color)
        {
            this.color = color;
        }

        public virtual void SetColor(IColor color)
        {
            this.color = color;
        }

        public abstract void Paint();
    }

    public class BigBrush : Brush
    {
        public BigBrush(IColor color)
            : base(color)
        {
        }

        public override void Paint()
        {
            Console.WriteLine($"Using [big] brush and [{this.color.Color}] color.");
        }
    }

    public class MiddleBrush : Brush
    {
        public MiddleBrush(IColor color)
            : base(color)
        {
        }

        public override void Paint()
        {
            Console.WriteLine($"Using [middle] brush and [{this.color.Color}] color.");
        }
    }

    public class SmallBrush : Brush
    {
        public SmallBrush(IColor color)
            : base(color)
        {
        }

        public override void Paint()
        {
            Console.WriteLine($"Using [small] brush and [{this.color.Color}] color.");
        }
    }
}
