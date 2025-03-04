using Hospital.Employee.Entities;

namespace Hospital.Employee.Dtos.DoctorDtos
{
    public class CreateDoctorDto
    {
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public string Title { get; set; }
        public int DepartmentId { get; set; }
    }
}
