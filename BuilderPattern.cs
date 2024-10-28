using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns
{
    public class Car
    {
        public string Name { get; set; }
        public string Engine { get; set; }
    }

    public class CarBuilder
    {
        private readonly Car _car = new();

        public CarBuilder SetName(string name)
        {
            _car.Name = name;
            return this;
        }

        public CarBuilder SetEngine(string engine)
        {
            _car.Engine = engine;
            return this;
        }

        public Car BuildCar()
        {
            return _car;
        }
    }
}
