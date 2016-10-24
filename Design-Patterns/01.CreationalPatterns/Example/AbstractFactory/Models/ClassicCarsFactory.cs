using AbstractFactory.Contracts;

namespace AbstractFactory.Models
{
    public class ClassicCarsFactory : ICarFactory
    {
        public IEngine CreateCar()
        {
            return new ClassicCar();
        }
    }
}
