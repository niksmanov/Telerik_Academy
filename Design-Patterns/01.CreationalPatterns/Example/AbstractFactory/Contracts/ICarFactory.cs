namespace AbstractFactory.Contracts
{
    public interface ICarFactory
    {
        IEngine CreateCar();
    }
}
