using Dp.Creational.AbstractFactory.Auto;
using Dp.Creational.AbstractFactory.Auto.Economy;
using Dp.Creational.AbstractFactory.Auto.Luxury;
using Dp.Creational.AbstractFactory.Auto.Sports;

namespace Dp.Creational.AbstractFactory.Factory
{
    public class PorscheFactory : IAutoFactory
    {
        public IAuto CreateEconomyCar() => new PorscheEconomy($"Porsche 718 Spyder");
        public IAuto CreateLuxuryCar() => new PorscheLuxury($"Porsche Cayanne Coupe");
        public IAuto CreateSportsCar() => new PorscheSports($"Porsche 911 Turbo");
    }
}
