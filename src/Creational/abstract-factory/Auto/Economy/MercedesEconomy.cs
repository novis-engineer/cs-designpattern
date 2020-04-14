using Dp.Creational.AbstractFactory.Auto.Base;
using System;
using static System.Console;

namespace Dp.Creational.AbstractFactory.Auto.Economy
{
    public class MercedesEconomy : Car
    {
        public MercedesEconomy(string name)
            : base(name)
        {

        }

        public override void TurnOn()
        {
            base.TurnOn();
            WriteLine($"Gives a mileage of 15 KmpL on highway and 8 KmpL in the city.");
        }
    }
}
