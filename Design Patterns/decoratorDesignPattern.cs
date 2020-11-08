using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decoratorPattern
{
    public interface Icar
    {
        Icar ManufactureCar();
    }

    public class BMWCar : Icar
    {
        private string CarName = "BMW";
        public string CarBody { get; set; }
        public string CarDoor { get; set; }
        public string CarGlass { get; set; }
        public string Engine { get; set; }

        public override string ToString()
        {
            return "BMWCar [CarName:" + CarName + ", " + "CarBody:" + CarBody + ", " + "CarDoor:" + CarDoor + ", " + "CarGlass:" + CarGlass + ", " + "Engine:" + Engine + "]";
        }

        public Icar ManufactureCar()
        {
            CarBody = "Carbon Fiber Material";
            CarDoor = "4 Car Doors";
            CarGlass = "4 MRF Wheels";
            return this;
        }
        public abstract class CarDecorator : Icar
        {
            protected Icar car;
            public CarDecorator(Icar car)
            {
                this.car = car;
            }
            public virtual Icar ManufactureCar()
            {
                return car.ManufactureCar();
            }
        }
        public class DieselCarDecorator : CarDecorator
        {
            public DieselCarDecorator(Icar car) : base(car)
            {
            }
            public override Icar ManufactureCar()
            {
                car.ManufactureCar();
                AddEngine(car);
                return car;
            }
            public void AddEngine(Icar car)
            {
                if (car is BMWCar)
                {
                    BMWCar BMWCar = (BMWCar)car;
                    BMWCar.Engine = "Diesel Engine";
                    Console.WriteLine("Car Decorator has added Diesel Engine to the car" + car);

                }
            }
        }
        public class PetrolCarDecorator : CarDecorator
        {
            public PetrolCarDecorator(Icar car) : base(car)
            {
            }
            public override Icar ManufactureCar()
            {
                car.ManufactureCar();
                AddEngine(car);
                return car;
            }
            public void AddEngine(Icar car)
            {
                if (car is BMWCar)
                {
                    BMWCar BMWCar = (BMWCar)car;
                    BMWCar.Engine = "Petrol Engine";
                    Console.WriteLine("Car Decorator has added Petrol Engine to the car" + car);

                }
            }
        }





        class decoratorDesignPattern
        {
            static void Main(string[] args)
            {
                Icar bmwCar1 = new BMWCar();
                bmwCar1.ManufactureCar();
                Console.WriteLine(bmwCar1 + "\n");

                DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(bmwCar1);
                carWithDieselEngine.ManufactureCar();
                Console.WriteLine();

                Icar bmwCar2 = new BMWCar();
                bmwCar2.ManufactureCar();
                Console.WriteLine(bmwCar2 + "\n");

                PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
                carWithPetrolEngine.ManufactureCar();

                Console.ReadKey();

            }
        }
    }
}
