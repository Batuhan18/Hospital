using Hospital.Employee.Dtos.NurseDtos;
using Hospital.Employee.Services.DepartmentServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _departmentsService;

        public DepartmentsController(IDepartmentService departmentsService)
        {
            _departmentsService = departmentsService;
        }

        [HttpGet]
        public async Task<IActionResult> DepartmentList()
        {
            var value = await _departmentsService.GetAllDepartmentAsync();
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDepartment(CreateDepartmentDto createDepartmentDto)
        {
            await _departmentsService.CreateDepartmentAsync(createDepartmentDto);
            return Ok("Ekleme Başarılı");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            await _departmentsService.DeleteDepartmentAsync(id);
            return Ok("Silme Başarılı");
        }

        [HttpGet("GetDepartment")]
        public async Task<IActionResult> GetDepartment(int id)
        {
            return Ok(await _departmentsService.GetByIdDepartment(id));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDepartment(UpdateDepartmentDto updateDepartmentDto)
        {
            await _departmentsService.UpdateDepartmentAsync(updateDepartmentDto);
            return Ok("Güncelleme Başarılı");
        }
    }
}
