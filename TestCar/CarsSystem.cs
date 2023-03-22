using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCar
{
    public class CarSystem
    {
        private static CarSystem? instance = null;
        private static string carsFilePath = "C:\\Users\\deriye\\Desktop\\Skola\\Prog2\\AdminHandlesCars\\AdminHandlesCars\\cars.txt";

        private List<Car> cars = new List<Car>();

        public List<Car> GetCars() { return cars; }

        private CarSystem()
        {
            LoadCars();
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
            Save();
        }

        public void Save()
        {

            string[] carsStringArr = cars.Select(car => $"{car.Id} {car.Brand} {car.Model} {car.ModelYear}").ToArray();


            File.WriteAllLines(carsFilePath, carsStringArr);
        }

        public static CarSystem GetInstance()
        {
            if (instance == null)
            {
                instance = new CarSystem();
            }
            return instance;
        }

        public List<Car> FindCar(string text)
        {
            var result = new List<Car>();

            foreach (var car in cars)
            {
                var includeCar = false;

                if (car.Brand.ToLower().Contains(text.ToLower()))
                {
                    includeCar = true;
                }

                if (car.Model.ToLower().Contains(text.ToLower()))
                {
                    includeCar = true;
                }

                if (car.ModelYear.ToLower().Contains(text.ToLower()))
                {
                    includeCar = true;
                }

                if (includeCar)
                {
                    result.Add(car);
                }
            }

            return result;
        }

        void LoadCars()
        {
            string data = File.ReadAllText(@"C:\Users\deriye\Desktop\Skola\Prog2\Search\Search\cars.json");
            dynamic carsData = JsonConvert.DeserializeObject<dynamic>(data);

            foreach (var c in carsData)
            {
                Car car = new Car((string)c.id, (string)c.car, (string)c.car_model, (string)c.car_model_year, (string)c.price, (string)c.availability);
                cars.Add(car);
            }
        }
    }
}
