﻿using System;
using System.Reflection;

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
            //Set the properties for each of the cars
            //Call each of the methods for each car

            CarLot carLot = new CarLot();

            Car car1 = new Car();
            car1.year = 2022;
            car1.make = "Lamborghini";
            car1.model = "Aventador";
            car1.engineNoise = "brrrrbrrrr";
            car1.honkNoise = "bloop";
            car1.isDriveable = true;
            carLot.listOfCars.Add(car1);
            Console.WriteLine($"\nThere is {CarLot.numOfCars} in the car lot");


            Car car2 = new Car() { year = 2016, make = "Honda", model = "CRV", engineNoise = "kchkhchkhc", honkNoise = "beep", isDriveable = true };
            carLot.listOfCars.Add(car2);
            Console.WriteLine($"\nThere are {CarLot.numOfCars} in the car lot");


            Car car3 = new Car(1908, "Ford", "T", "boomba", "sploot", false);
            carLot.listOfCars.Add(car3);
            Console.WriteLine($"\nThere are {CarLot.numOfCars} in the car lot");
            Console.WriteLine("\n-----------------------------");

            Console.WriteLine("Car Noises~");
            car1.MakeEngineNoise(car1.engineNoise);
            car1.MakeHonkNoise(car1.honkNoise);
            car2.MakeEngineNoise(car2.engineNoise);
            car2.MakeHonkNoise(car2.honkNoise);
            car3.MakeEngineNoise(car3.engineNoise);
            car3.MakeHonkNoise(car3.honkNoise);

            Console.WriteLine("\nCars in car lot: \n-----------------------------");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            carLot.allCarDetails();

        }
    }
}
