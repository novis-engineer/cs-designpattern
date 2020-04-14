using Dp.Creational.AbstractFactory.Auto.Base;
using static System.Console;

namespace Dp.Creational.AbstractFactory.Auto.Sports
{
    public class VolvoSports : Car
    {
        public VolvoSports(string name)
            : base(name)
        {

        }

        public override void TurnOn()
        {
            base.TurnOn();
            WriteLine($"Goes 0-100 Kms in 4 seconds.");
        }
    }
}
