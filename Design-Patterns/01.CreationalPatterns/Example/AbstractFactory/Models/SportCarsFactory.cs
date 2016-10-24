using AbstractFactory.Contracts;

namespace AbstractFactory.Models
{
    public class SportCarsFactory : ICarFactory
    {
        public IEngine CreateCar()
        {
            return new SportCar();
        }
    }
}
