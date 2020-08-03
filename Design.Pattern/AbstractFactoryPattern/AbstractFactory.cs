namespace Design.Pattern.AbstractFactoryPattern
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstarctProductB CreateProductB();
    }

    public abstract class AbstractProductA
    {
        public abstract void Interact(AbstarctProductB productB);
    }

    public abstract class AbstarctProductB
    {
        public abstract void Interact(AbstractProductA productA);
    }
}
