namespace Design.Pattern.BuilderPattern
{
    public abstract class Builder
    {
        public abstract void BuildDoor();
        public abstract void BuildWall();
        public abstract void BuildWindows();
        public abstract void BuildFloor();
        public abstract void BuildHouseCelling();

        public abstract House GetHouse();
    }

    public class House
    {
        public void Show()
        {

        }
    }
}
