using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Design.Pattern.BridgePattern;

namespace Design.Pattern.Test
{
    public class BridgeTest
    {
        [Fact]
        public void Test()
        {
            var red = new RedColor();
            var blue = new BlueColor();
            var yellow = new YellowColor();

            var bigbrush = new BigBrush(red);
            var middlebrush = new MiddleBrush(red);

            var brush = new BrushDemo(bigbrush);

            brush.UseBrush();
            brush.SetColor(blue);
            brush.UseBrush();
            brush.SetColor(yellow);
            brush.UseBrush();

            brush.SetSize(middlebrush);
            brush.UseBrush();
            brush.SetColor(blue);
            brush.UseBrush();
        }
    }
}
