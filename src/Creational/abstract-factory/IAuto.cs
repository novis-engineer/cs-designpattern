namespace Dp.Creational.AbstractFactory
{
    public interface IAuto
    {
        string Name { get; }
        void TurnOff();
        void TurnOn();
    }
}
