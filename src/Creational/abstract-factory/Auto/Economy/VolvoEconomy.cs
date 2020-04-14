using Dp.Creational.AbstractFactory.Auto.Base;
using static System.Console;

namespace Dp.Creational.AbstractFactory.Auto.Economy
{
    public class VolvoEconomy : Car
    {
        public VolvoEconomy(string name)
            : base(name)
        {

        }

        public override void TurnOn()
        {
            base.TurnOn();
            WriteLine($"Gives a mileage of 20 KmpL on highway and 10-12 KmpL in the city.");
        }
    }
}
