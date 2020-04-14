using Dp.Creational.AbstractFactory.Auto.Base;
using static System.Console;

namespace Dp.Creational.AbstractFactory.Auto.Sports
{
    public class PorscheSports : Car
    {
        public PorscheSports(string name)
            : base(name)
        {

        }

        public override void TurnOn()
        {
            base.TurnOn();
            WriteLine($"Goes 0-100 Kms in 2.8 seconds.");
        }
    }
}
