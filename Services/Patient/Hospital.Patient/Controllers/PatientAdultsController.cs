using Hospital.Patient.Dtos.PatientAdultDtos;
using Hospital.Patient.Services.PatientAdultServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Patient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientAdultsController : ControllerBase
    {
        private readonly IPatientAdultServices _patientAdultServices;

        public PatientAdultsController(IPatientAdultServices patientAdultServices)
        {
            _patientAdultServices = patientAdultServices;
        }

        [HttpGet]
        public async Task<IActionResult> PatientAdultList()
        {
            var values = await _patientAdultServices.GetAllPatientAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePatientAdult(CreatePatientAdultDto createPatientAdultDto)
        {
            await _patientAdultServices.CreatePatientAdultAsync(createPatientAdultDto);
            return Ok("Ekleme başarılı");
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePatientAdult(string id)
        {
            await _patientAdultServices.DeletePatientAdultAsync(id);
            return Ok("Silme başarılı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePatientAdult(UpdatePatientAdultDto updatePatientAdultDto)
        {
            await _patientAdultServices.UpdatePatientAdultAsync(updatePatientAdultDto);
            return Ok("Güncelleme başarılı");
        }

        [HttpGet("GetPatientAdult")]
        public async Task<IActionResult> GetPatientAdult(string id)
        {
            var value = await _patientAdultServices.GetByIdPatientAdultAsync(id);
            return Ok(value);
        }
    }
}
