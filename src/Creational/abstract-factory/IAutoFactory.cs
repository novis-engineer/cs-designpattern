namespace Dp.Creational.AbstractFactory
{
    public interface IAutoFactory
    {
        IAuto CreateEconomyCar();
        IAuto CreateLuxuryCar();
        IAuto CreateSportsCar();
    }
}
