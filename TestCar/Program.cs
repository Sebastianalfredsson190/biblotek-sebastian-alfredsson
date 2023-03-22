using System;
using System.Xml.Linq;

namespace TestCar
{
    public class Program
    {
        static CarSystem system = CarSystem.GetInstance();

        static void Main(string[] args)
        {
            
            Console.WriteLine("\u001b[2J\u001b[3J");

            while (true)
            {
                Console.Write("Sök efter en bil: ");
                var query = Console.ReadLine();
                Console.WriteLine("\n");

                // raderar historiken i terminalen (ascii erase display)
                Console.WriteLine("\u001b[2J\u001b[3J");
                Console.Clear();


                Console.WriteLine($"Sök efter en bil: {query}\n");

                var result = system.FindCar(query);

                for (var i = 0; i < result.Count; i++)
                {
                    var car = result[i];

                    Console.WriteLine($"Model: {car.Model}");
                    Console.WriteLine($"Brand: {car.Brand}");
                    Console.WriteLine($"Model Year:{car.ModelYear}");
                    Console.WriteLine($"Price: {car.Price}\n");
                }
            }
        }
    }
}