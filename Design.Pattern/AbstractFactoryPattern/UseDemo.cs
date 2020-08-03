namespace Design.Pattern.AbstractFactoryPattern
{
    public class UseDemo
    {
        public void Use()
        {
            var factory1 = new InstanceFactory1();
            var client1 = new Client(factory1);
            client1.Run();

            var factory2 = new InstanceFactory2();
            var client2 = new Client(factory2);
            client2.Run();
        }
    }
}
