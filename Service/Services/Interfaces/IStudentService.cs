using Domain.Entities;
using Service.DTOs.Admin.Student;

namespace Service.Services.Interfaces
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentDto>> GetAllAsync();
        Task CreateAsync(StudentCreateDto request);
        Task DeleteAsync(int? id);
        Task EditAsync(int id, StudentEditDto request);
        Task<StudentDto> GetById(int id);
    }
}
