using dsMotor.Domain.Entities;

namespace dsMotor.Application.ViewModel
{
    public class MotorcycleViewModel
    {
        public int Id { get; private set; }
        public string Model { get;  set; }
        public string  Plate { get;  set; }
        public string Color { get;  set; }
        public int Age { get;  set; }

        public MotorcycleViewModel(string model, string plate, string color, int age)
        {
            Model = model;
            Plate = plate;
            Color = color;
            Age = age;
        }

        public MotorcycleViewModel(Motorcycle m)
        {
            Id = m.Id;
            Model = m.Model;
            Plate = m.Plate;
            Color = m.Color;
            Age = m.Age;
        }
    }
}
