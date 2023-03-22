using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCar
{
    public class Car
    {
        public string Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string ModelYear { get; set; }
        public string Price { get; set; }
        public string Availability { get; set; }

        public Car(string Id, string Brand, string Model, string ModelYear, string Price, string Availability)
        {
            this.Id = Id;
            this.Brand = Brand;
            this.Model = Model;
            this.ModelYear = ModelYear;
            this.Price = Price;
            this.Availability = Availability;
        }

    }
}
