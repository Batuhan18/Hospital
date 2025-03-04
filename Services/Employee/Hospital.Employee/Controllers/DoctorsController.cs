using Hospital.Employee.Dtos.DoctorDtos;
using Hospital.Employee.Dtos.NurseDtos;
using Hospital.Employee.Services.DoctorServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService _DoctorsService;

        public DoctorsController(IDoctorService DoctorsService)
        {
            _DoctorsService = DoctorsService;
        }

        [HttpGet]
        public async Task<IActionResult> DoctorList()
        {
            var value = await _DoctorsService.GetAllDoctorAsync();
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDoctor(CreateDoctorDto createDoctorDto)
        {
            await _DoctorsService.CreateDoctorAsync(createDoctorDto);
            return Ok("Ekleme Başarılı");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            await _DoctorsService.DeleteDoctorAsync(id);
            return Ok("Silme Başarılı");
        }

        [HttpGet("GetDoctor")]
        public async Task<IActionResult> GetDoctor(int id)
        {
            return Ok(await _DoctorsService.GetByIdDoctor(id));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDoctor(UpdateDoctorDto updateDoctorDto)
        {
            await _DoctorsService.UpdateDoctorAsync(updateDoctorDto);
            return Ok("Güncelleme Başarılı");
        }
    }
}
