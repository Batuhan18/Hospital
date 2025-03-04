using Hospital.Employee.Dtos.DepartmentDtos;
using Hospital.Employee.Dtos.NurseDtos;

namespace Hospital.Employee.Services.DepartmentServices
{
    public interface IDepartmentService
    {
        Task<List<ResultDepartmentDto>> GetAllDepartmentAsync();
        Task CreateDepartmentAsync(CreateDepartmentDto createDepartmentDto);
        Task UpdateDepartmentAsync(UpdateDepartmentDto updateDepartmentDto);
        Task DeleteDepartmentAsync(int id);
        Task<GetByIdDepartmentDto> GetByIdDepartment(int id);
    }
}
