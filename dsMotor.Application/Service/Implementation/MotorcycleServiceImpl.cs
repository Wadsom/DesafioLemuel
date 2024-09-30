using dsMotor.Application.InputModel;
using dsMotor.Application.Service.Interface;
using dsMotor.Application.ViewModel;
using dsMotor.Domain.Entities;
using dsMotor.Infra.Persistence;
using Microsoft.Extensions.Logging;

namespace dsMotor.Application.Service.Implementation
{
    public class MotorcycleServiceImpl : IMotorcycleService
    {
        private readonly DsMotorDbContext _db;
        private readonly ILogger<MotorcycleServiceImpl> _logger;

        public MotorcycleServiceImpl(DsMotorDbContext db, ILogger<MotorcycleServiceImpl> logger)
        {
            _logger = logger;
            _db = db;
        }

        public int Create(CreateMotorcycleInputModel moto)
        {
            _db.ToString();
            _logger.LogInformation("Con _DB: {@_db}", _db);
            _logger.LogInformation("Criando motocicleta: {@Moto}", moto);
            if (moto == null)
            {
                throw new ArgumentNullException(nameof(moto), "O modelo de motocicleta não pode ser nulo.");
            }

            if (string.IsNullOrEmpty(moto.Model) || string.IsNullOrEmpty(moto.ToString()))
            {
                throw new ArgumentException("O modelo e o fabricante devem ser fornecidos.");
            }

            Motorcycle mt = new Motorcycle(moto.Model, moto.Age, moto.Plate, moto.Color);
            _db.Motorcycle.Add(mt);
            _db.SaveChanges();
            return mt.Id;
        }

        public MotorcycleViewModel GetById(int id)
        {
            var mdn = _db.Motorcycle.FirstOrDefault(mt => mt.Id == id);
            if (mdn == null)
            {
                throw new ArgumentException($"Motocicleta com ID {id} não encontrada.");
            }

            MotorcycleViewModel vm = new MotorcycleViewModel(
                mdn.Model, mdn.Plate, mdn.Color, mdn.Age
            );
            return vm;
        }

        public void Update(int Id, UpdateMotorcycleInputModel input)
        {
            var moto = _db.Motorcycle.FirstOrDefault(mt => mt.Id == Id);
            if (moto == null)
            {
                throw new ArgumentException($"Motocicleta com ID {Id} não encontrada.");
            }

           
            moto.Update(input.Model, input.Age, input.Plate, input.Color);
            _logger.LogInformation("Nova moto : {@moto}", moto.ToString());
            _db.Motorcycle.Update(moto);
            _db.SaveChanges();
        }

        public void Delete(int Id)
        {
            var moto = _db.Motorcycle.FirstOrDefault(mt => mt.Id == Id);
            if (moto == null) throw new ArgumentException("Moto não existe.");
            _db.Motorcycle.Remove(moto);
            _db.SaveChanges();
        }

        public List<MotorcycleViewModel> GetAll()
        {
            var models = _db.Motorcycle.ToList();
            return models.Select(md => new MotorcycleViewModel(md)).ToList();
        }
    }
}