using System;

namespace Design.Pattern.DecoratorPattern
{
    public abstract class Tank
    {
        public string Name { get; }

        public Tank(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));

            this.Name = name;
        }

        public abstract void Shoot();
        public abstract void Run();
    }
}
