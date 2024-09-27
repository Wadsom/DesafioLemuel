using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsMotor.Domain.Entities
{
    public class Motorcycle
    {
        public int Id { get; private set; }
        public string  Model { get; private set; }
        public int Age { get; private set; }
        public string  Plate { get; private set; }
        public string  Color { get; private set; }

        public Motorcycle(string model, int age, string plate, string color)
        {
            Model = model;
            Age = age;
            Plate = plate;
            Color = color;
        }
    }
}
