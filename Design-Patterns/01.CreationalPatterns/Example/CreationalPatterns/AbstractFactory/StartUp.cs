using AbstractFactory.Contracts;
using AbstractFactory.Models;

namespace AbstractFactory
{
    public class StartUp
    {
        public static void Main()
        {
            ICarFactory classicCarsFactory = new ClassicCarsFactory();
            ICarFactory sportCardFactory = new SportCarsFactory();

            IEngine classicCar = classicCarsFactory.CreateCar();
            IEngine sportCar = sportCardFactory.CreateCar();

            classicCar.Start();
            sportCar.Start();
        }
    }
}
