using AutoMapper;
using Domain.Entities;
using Service.DTOs.Admin.Student;
using System.Diagnostics.Metrics;

namespace Service.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<StudentCreateDto, Student>();
        }
    }
}
