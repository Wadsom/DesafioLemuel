using dsMotor.Application.InputModel;
using dsMotor.Application.Service.Interface;
using dsMotor.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace dsMotor.API.Controllers
{
    [Route("v1/Motorcycle")]
    public class MotorcycleController : ControllerBase
    {
        private readonly IMotorcycleService _motorcycleService;

        public MotorcycleController(IMotorcycleService motorcycleService)
        {
            _motorcycleService = motorcycleService;
        }

        [HttpGet]
        public IActionResult GetMotorcycles()
        {
            var lista = _motorcycleService.GetAll();
            return Ok(lista);
        }

        [HttpGet("{id}")]
        public IActionResult GetMotorById(int id)
        {
            var motor = _motorcycleService.GetById(id);
            return Ok(motor);
        }

        [HttpPost]
        public IActionResult CreateNewMotor([FromBody] CreateMotorcycleInputModel moto)
        {
            var id = _motorcycleService.Create(moto);
            return CreatedAtAction(nameof(GetMotorById), new { id = id }, moto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMotor(int id, [FromBody] UpdateMotorcycleInputModel moto)
        {
            _motorcycleService.Update(id, moto);
            return Ok("Success");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMotor(int id)
        {
            _motorcycleService.Delete(id);
            return NoContent();
        }
    }
}