using System;

namespace Facade.Models
{
    /// <summary>
    /// The Facade of the car
    /// </summary>
    public class Workshop
    {
        private readonly CarModel model;
        private readonly CarEngine engine;
        private readonly CarBody body;
        private readonly CarAccessories accessories;

        public Workshop()
        {
            this.model = new CarModel();
            this.engine = new CarEngine();
            this.body = new CarBody();
            this.accessories = new CarAccessories();
        }

        public void CreateCar()
        {
            Console.WriteLine("Start creating a car...");
            model.SetModel();
            engine.SetEngine();
            body.SetBody();
            accessories.SetAccessories();

            Console.WriteLine("Car creation is completed!");
        }
    }
}
