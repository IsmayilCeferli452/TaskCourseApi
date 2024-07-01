using Domain.Entities;

namespace Repository.Repositories.Interfaces
{
    public interface IStudentRepository : IBaseRepository<Student>
    {
        Task<IEnumerable<Student>> GetAllWithGroup();
        Task<Student> GetByIdWithGroup(int id);
    }
}
