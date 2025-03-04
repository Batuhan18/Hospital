using Hospital.Employee.Entities;

namespace Hospital.Employee.Dtos.DoctorDtos
{
    public class ResultDoctorDto
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public string Title { get; set; }
        public int DepartmentId { get; set; }
    }
}
