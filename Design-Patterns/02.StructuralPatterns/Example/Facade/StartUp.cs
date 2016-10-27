using Facade.Models;

namespace Facade
{
    public class StartUp
    {
        public static void Main()
        {
            var workshop = new Workshop(); //the facade
            workshop.CreateCar();
        }
    }
}
