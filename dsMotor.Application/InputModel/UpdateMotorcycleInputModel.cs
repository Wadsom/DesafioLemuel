namespace dsMotor.Application.InputModel
{
    public class UpdateMotorcycleInputModel
    {
        public string Model { get;  set; }
        public int Age { get; set; }
        public string Plate { get; set; }
        public string Color { get; set; }

        public UpdateMotorcycleInputModel(string model, int age, string plate, string color)
        {
            Model = model;
            Age = age;
            Plate = plate;
            Color = color;
        }
    }
}
