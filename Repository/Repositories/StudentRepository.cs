using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Student>> GetAllWithGroup()
        {
            return await _context.Students.Include(m => m.StudentGroups).ThenInclude(m => m.Group).ToListAsync();
        }

        public async Task<Student> GetByIdWithGroup(int id)
        {
            return await _context.Students.Include(m => m.StudentGroups).ThenInclude(m => m.Group).FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
