using Dp.Creational.AbstractFactory.Auto;
using Dp.Creational.AbstractFactory.Auto.Economy;
using Dp.Creational.AbstractFactory.Auto.Luxury;
using Dp.Creational.AbstractFactory.Auto.Sports;

namespace Dp.Creational.AbstractFactory.Factory
{
    public class MercedesFactory : IAutoFactory
    {
        public IAuto CreateEconomyCar() => new MercedesEconomy($"Mercedes C-Class");
        public IAuto CreateLuxuryCar() => new MercedesLuxury($"Mercedes S-Class Maybach");
        public IAuto CreateSportsCar() => new MercedesSports($"Mercedes-AMG GT R");
    }
}
