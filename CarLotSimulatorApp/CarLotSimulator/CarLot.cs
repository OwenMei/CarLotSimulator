using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class CarLot
    {

        public static int numOfCars = 0;
        public List<Car> listOfCars { get; set; }

        public CarLot() 
        {
            listOfCars = new List<Car>();
        }

        public void allCarDetails()
        {
            foreach(Car automobile in listOfCars)
            {
                Console.Write(automobile.year + " ");
                Console.Write(automobile.make + " ");
                Console.WriteLine(automobile.model);
            }
        }
    }
}
