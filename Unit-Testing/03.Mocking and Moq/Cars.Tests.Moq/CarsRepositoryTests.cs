namespace Cars.Tests.Moq
{
    using System;
    using System.Collections.Generic;
    using Cars.Contracts;
    using Cars.Controllers;
    using Cars.Models;
    using NUnit.Framework;
    using global::Moq;
    using Data;

    [TestFixture]
    public class CarsRepositoryTests
    {
        private CarsController controller;

        [Test]
        public void CarsRepository_SaveDatabase_ReturnsTrue()
        {
            var mockedDatabase = new Mock<IDatabase>();

            var carsRepository = new CarsRepositoryChild(mockedDatabase.Object);

            Assert.AreSame(mockedDatabase.Object, carsRepository.GetData());
        }

        [Test]
        public void CarsRepositoryCarsCount_ValidCount_ReturnsTrue()
        {
            var carsDatabase = new List<Car>();
            carsDatabase.Add(new Car { Id = 1, Make = "BMW", Model = "530", Year = 1998 });
            carsDatabase.Add(new Car { Id = 2, Make = "Mercedes", Model = "E320", Year = 2000 });
            carsDatabase.Add(new Car { Id = 3, Make = "Opel", Model = "Frontera", Year = 1994 });
            carsDatabase.Add(new Car { Id = 4, Make = "Peugeot", Model = "307", Year = 2003 });
            carsDatabase.Add(new Car { Id = 5, Make = "Fiat", Model = "Panda", Year = 2005 });

            var mockedDatabase = new Mock<IDatabase>();
            mockedDatabase.Setup(c => c.Cars).Returns(carsDatabase);
            var carsRepository = new CarsRepository(mockedDatabase.Object);

            var expectedCount = 5;

            Assert.AreEqual(expectedCount, carsRepository.TotalCars);
        }

        [Test]
        public void CarsRepository_AddNullCar_ThrowsArgumentException()
        {
            var carsRepository = new CarsRepository(new Mock<IDatabase>().Object);
            var exception = Assert.Catch<ArgumentException>(() => carsRepository.Add(null));
            StringAssert.Contains("Null car cannot be added", exception.Message);
        }

        [Test]
        public void CarsRepository_AddValidCar_ReturnsTrue()
        {
            var car = new Car { Id = 6, Make = "Audi", Model = "A6", Year = 2008 };
            var carsDatabase = new List<Car>();

            var mockedDatabase = new Mock<IDatabase>();
            mockedDatabase.Setup(c => c.Cars).Returns(carsDatabase);

            var carsRepository = new CarsRepositoryChild(mockedDatabase.Object);
            carsRepository.Add(car);

            Assert.Contains(car, carsDatabase);
        }


        [Test]
        public void CarsRepository_RemoveNullCar_ThrowsArgumentException()
        {
            var carsRepository = new CarsRepository(new Mock<IDatabase>().Object);
            var exception = Assert.Catch<ArgumentException>(() => carsRepository.Remove(null));
            StringAssert.Contains("Null car cannot be removed", exception.Message);
        }

        [Test]
        public void CarsRepository_RemoveValidCar_ReturnsTrue()
        {
            var car = new Car { Id = 6, Make = "Audi", Model = "A6", Year = 2008 };
            var carsDatabase = new List<Car>();

            var mockedDatabase = new Mock<IDatabase>();
            mockedDatabase.Setup(c => c.Cars).Returns(carsDatabase);

            var carsRepository = new CarsRepositoryChild(mockedDatabase.Object);
            carsRepository.Remove(car);

            var contains = carsDatabase.Contains(car);
            Assert.IsFalse(contains);
        }

        [Test]
        public void CarsRepository_AddCarWithNullId_ThrowsArgumentException()
        {
            var car = new Car { Id = 8, Make = "Audi", Model = "R8", Year = 2014 };
            var carsDatabase = new List<Car>();

            var mockedDatabase = new Mock<IDatabase>();
            mockedDatabase.Setup(c => c.Cars).Returns(carsDatabase);

            var carsRepository = new CarsRepositoryChild(mockedDatabase.Object);

            var exception = Assert.Catch<ArgumentException>(() => carsRepository.GetById(car.Id));
            StringAssert.Contains("Car with such Id could not be found", exception.Message);
        }

        [Test]
        public void CarsRepository_AddCarWithNullMake_ThrowsArgumentNullException()
        {

            var car = new Car { Id = 9, Make = null, Model = "A6", Year = 2008 };
            var carsDatabase = new List<Car>();

            var mockedDatabase = new Mock<IDatabase>();
            mockedDatabase.Setup(c => c.Cars).Returns(carsDatabase);

            var carsRepository = new CarsRepositoryChild(mockedDatabase.Object);

            controller = new CarsController(carsRepository);

            Assert.Throws(typeof(ArgumentNullException), () => this.controller.Add(car));
         }

        [Test]
        public void CarsRepository_AddCarWithNullModel_ThrowsArgumentNullException()
        {

            var car = new Car { Id = 9, Make = "Audi", Model = null, Year = 2008 };
            var carsDatabase = new List<Car>();

            var mockedDatabase = new Mock<IDatabase>();
            mockedDatabase.Setup(c => c.Cars).Returns(carsDatabase);

            var carsRepository = new CarsRepositoryChild(mockedDatabase.Object);

            controller = new CarsController(carsRepository);

            Assert.Throws(typeof(ArgumentNullException), () => this.controller.Add(car));
        }

       




    }
}

