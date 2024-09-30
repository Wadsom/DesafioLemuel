using dsMotor.Application.InputModel;
using dsMotor.Application.ViewModel;

namespace dsMotor.Application.Service.Interface
{
    public interface IMotorcycleService
    {
        int Create(CreateMotorcycleInputModel moto);
        MotorcycleViewModel GetById(int Id);
        void Update(int Id, UpdateMotorcycleInputModel input);
        void Delete(int  Id);
        List<MotorcycleViewModel> GetAll();
    }
}
