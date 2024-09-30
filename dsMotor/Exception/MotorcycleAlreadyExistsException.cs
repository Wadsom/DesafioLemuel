

namespace dsMotor.Domain.Exception
{
    public class MotorcycleAlreadyExistsException : System.Exception
    {
        public MotorcycleAlreadyExistsException() : base("Motor already exists with plate")
        {
        }
    }
}
