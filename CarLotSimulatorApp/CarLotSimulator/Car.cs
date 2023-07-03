using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        public int year { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string engineNoise { get; set; }
        public string honkNoise { get; set; }
        public bool isDriveable { get; set; }

        public Car()
        {
            CarLot.numOfCars += 1;
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            this.year = year;
            this.make = make;
            this.model = model;
            this.engineNoise = engineNoise;
            this.honkNoise = honkNoise;
            this.isDriveable = isDriveable;
            CarLot.numOfCars += 1;
        }

        public void MakeHonkNoise(string honk)
        {
            Console.WriteLine(honk);
        }

        public void MakeEngineNoise(string engine)
        {
            Console.WriteLine(engine);
        }
    }
}
