using Dp.Creational.AbstractFactory.Auto.Base;
using static System.Console;

namespace Dp.Creational.AbstractFactory.Auto.Economy
{
    public class PorscheEconomy : Car
    {
        public PorscheEconomy(string name)
            : base(name)
        {

        }

        public override void TurnOn()
        {
            base.TurnOn();
            WriteLine($"Gives a mileage of 13 KmpL on highway and 6 KmpL in the city.");
        }
    }
}
