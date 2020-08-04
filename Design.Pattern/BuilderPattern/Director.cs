namespace Design.Pattern.BuilderPattern
{
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildWall();
            builder.BuildDoor();
            builder.BuildFloor();
            builder.BuildWindows();
            builder.BuildHouseCelling();
        }
    }
}
