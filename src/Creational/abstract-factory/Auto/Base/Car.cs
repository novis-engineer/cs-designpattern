using static System.Console;

namespace Dp.Creational.AbstractFactory.Auto.Base
{
    public class Car : IAuto
    {
        public string Name { get; }

        public Car(string name)
        {
            Name = name;
        }

        public virtual void TurnOff() => WriteLine($"The {Name} is shutting down.");
        public virtual void TurnOn() => WriteLine($"The {Name} is up and running.");
    }
}
