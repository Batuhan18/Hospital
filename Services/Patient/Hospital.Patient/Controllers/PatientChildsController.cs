using Hospital.Patient.Dtos.PatientChildDtos;
using Hospital.Patient.Services.PatientChildServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Patient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientChildsController : ControllerBase
    {
        private readonly IPatientChildServices _patientChildServices;

        public PatientChildsController(IPatientChildServices patientChildServices)
        {
            _patientChildServices = patientChildServices;
        }

        [HttpGet]
        public async Task<IActionResult> PatientChildList()
        {
            var value = await _patientChildServices.GetAllPatientChildAsync();
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePatientChild(CreatePatientChildDto createPatientChildDto)
        {
            await _patientChildServices.CreatePatientChildAsync(createPatientChildDto);
            return Ok("Ekleme Başarılı");
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePatientChild(string id)
        {
            await _patientChildServices.DeletePatientChildAsync(id);
            return Ok("Silme işlemi başarılı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePatientChild(UpdatePatientChildDto updatePatientChildDto)
        {
            await _patientChildServices.UpdatePatientChildAsync(updatePatientChildDto);
            return Ok("Güncelleme başarılı");
        }

        [HttpGet("GetPatientChild")]
        public async Task<IActionResult> GetPatientChild(string id)
        {
            var value = await _patientChildServices.GetByIdPatientChildAsync(id);
            return Ok(value);
        }
    }
}
