using Dp.Creational.AbstractFactory.Auto;
using Dp.Creational.AbstractFactory.Auto.Economy;
using Dp.Creational.AbstractFactory.Auto.Luxury;
using Dp.Creational.AbstractFactory.Auto.Sports;

namespace Dp.Creational.AbstractFactory.Factory
{
    public class VolvoFactory : IAutoFactory
    {
        public IAuto CreateEconomyCar() => new VolvoEconomy($"Volvo XC40");
        public IAuto CreateLuxuryCar() => new VolvoLuxury($"Volvo S90");
        public IAuto CreateSportsCar() => new VolvoSports($"Volvo Polestar");
    }
}
