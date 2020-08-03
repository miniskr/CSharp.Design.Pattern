using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Pattern.AbstractFactoryPattern
{
    public class Client
    {
        private readonly AbstractProductA _abstractProductA;
        private readonly AbstarctProductB _abstarctProductB;

        public Client(AbstractFactory factory)
        {
            this._abstractProductA = factory.CreateProductA();
            this._abstarctProductB = factory.CreateProductB();
        }

        public void Run()
        {
            this._abstractProductA.Interact(this._abstarctProductB);
            this._abstarctProductB.Interact(this._abstractProductA);
        }
    }
}
