using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interfaces;
using Service.DTOs.Admin.Student;
using Service.Services.Interfaces;

namespace Service.Services
{
    public class StudentService : IStudentService
    {
        private readonly IBaseRepository<Student> _baseRepo;
        private readonly IStudentRepository _studentRepo;
        private readonly IMapper _mapper;

        public StudentService(IBaseRepository<Student> baseRepo,
                              IMapper mapper,
                              IStudentRepository studentRepo)
        {
            _baseRepo = baseRepo;
            _mapper = mapper;
            _studentRepo = studentRepo;
        }

        public async Task CreateAsync(StudentCreateDto request)
        {
            if (request is null)
            {
                throw new ArgumentNullException();
            }

            await _studentRepo.CreateAsync(_mapper.Map<Student>(request));
        }

        public async Task DeleteAsync(int? id)
        {
            if (id is null)
            {
                throw new ArgumentNullException();
            }

            var student = await _baseRepo.GetByIdAsync((int)id);

            await _studentRepo.DeleteAsync(student);
        }

        public Task EditAsync(int id, StudentEditDto request)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<StudentDto>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<StudentDto>>(await _studentRepo.GetAllWithGroup());
        }

        public async Task<StudentDto> GetById(int id)
        {
            return _mapper.Map<StudentDto>(await _studentRepo.GetByIdWithGroup(id));
        }
    }
}
