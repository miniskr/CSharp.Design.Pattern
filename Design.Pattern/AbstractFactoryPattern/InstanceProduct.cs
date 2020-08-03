using System;

namespace Design.Pattern.AbstractFactoryPattern
{
    public class InstanceFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstarctProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    public class InstanceFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstarctProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    public class ProductA1 : AbstractProductA
    {
        public override void Interact(AbstarctProductB productB)
        {
            Console.WriteLine($"{this.GetType().Name} interact with {productB.GetType().Name}");
        }
    }

    public class ProductA2 : AbstractProductA
    {
        public override void Interact(AbstarctProductB productB)
        {
            Console.WriteLine($"{this.GetType().Name} interact with {productB.GetType().Name}");
        }
    }

    public class ProductB1 : AbstarctProductB
    {
        public override void Interact(AbstractProductA productA)
        {
            Console.WriteLine($"{this.GetType().Name} interact with {productA.GetType().Name}");
        }
    }

    public class ProductB2 : AbstarctProductB
    {
        public override void Interact(AbstractProductA productA)
        {
            Console.WriteLine($"{this.GetType().Name} interact with {productA.GetType().Name}");
        }
    }
}
