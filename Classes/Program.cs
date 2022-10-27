using System.Xml.Schema;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "GMC";
            myCar.Model = "Yukon";
            myCar.Year = 2021;

            var chevy = new Car()
            {
                Make = "Chevy",
                Model = "Tahoe",
                Year = 2019
            };
            var ford = new Car()
            {
                Make = "Ford",
                Model = "Bronco",
                Year = 2022

            };
            var carList = new List<Car>() { myCar, ford, chevy };
            
            foreach(var car in carList)
            {
                Console.WriteLine(car.Year);
                Console.WriteLine(car.Make);
                Console.WriteLine(car.Model);
                
            }
        }
    }
}
