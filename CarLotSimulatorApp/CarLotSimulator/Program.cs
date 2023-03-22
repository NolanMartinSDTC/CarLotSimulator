using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars

            var parkingLot = new CarLot();
            Console.WriteLine($"Number of cars in the lot: {CarLot.numOfCars}\n");
            //Car mySecondCar = new Car();
            //Car myThirdCar = new Car();

            // First way to set properties for first object (Dot Notation Syntax)

            Car myFirstCar = new Car();
            myFirstCar.Year = 2001;
            myFirstCar.Make = "Saturn";
            myFirstCar.Model = "Ion";
            myFirstCar.IsDriveable = false;
            myFirstCar.EngineNoise = "bzz";
            myFirstCar.HonkNoise = "beep";

            parkingLot.ListOfCars = new List<Car>();
            parkingLot.ListOfCars.Add(myFirstCar);

            CarLot.numOfCars++;
            Console.WriteLine($"Number of cars in the lot: {CarLot.numOfCars}\n");


            // Initializing and setting properties for second object (Object Initializer Syntax)

            var mySecondCar = new Car() { Year = 2012, Make = "Chevy", Model = "Cruze", IsDriveable = false, EngineNoise = "brr", HonkNoise = "baep" };
            parkingLot.ListOfCars.Add(mySecondCar);

            CarLot.numOfCars++;
            Console.WriteLine($"Number of cars in the lot: {CarLot.numOfCars}\n");

            // Third way to initialize object and set properties (Custom Constructors)

            Car myThirdCar = new Car
                (2022,
                "Toyota",
                "Tacoma",
                true,
                "BRRRR",
                "BAAP");
            parkingLot.ListOfCars.Add(myThirdCar);

            CarLot.numOfCars++;
            Console.WriteLine($"Number of cars in the lot: {CarLot.numOfCars}\n");

            //Call each of the methods for each car

            //myFirstCar.MakeEngineNoise();
            //myFirstCar.MakeHonkNoise();

            //mySecondCar.MakeEngineNoise();
            //mySecondCar.MakeHonkNoise();

            //myThirdCar.MakeEngineNoise();
            //myThirdCar.MakeHonkNoise();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            // SEE ABOVE

            foreach (Car car in parkingLot.ListOfCars)
            {
                Console.WriteLine($"Year: {car.Year} \nMake: {car.Make} \nModel: {car.Model}");
                car.MakeEngineNoise();
                car.MakeHonkNoise();
            }


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.

            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

        }
    }
}
