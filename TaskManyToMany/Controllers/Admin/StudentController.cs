using Microsoft.AspNetCore.Mvc;
using Service.DTOs.Admin.Student;
using Service.Helpers.Exceptions;
using Service.Services.Interfaces;

namespace TaskManyToMany.Controllers.Admin
{
    public class StudentController : BaseController
    {
        private readonly IStudentService _studentService;
        private readonly ILogger<StudentController> _logger;

        public StudentController(IStudentService studentService, ILogger<StudentController> logger)
        {
            _studentService = studentService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            _logger.LogInformation("GetAll method worked");

            var students = await _studentService.GetAllAsync();

            if (students.Count() < 1)
            {
                throw new NotFoundException("Student not found");
            }

            return Ok(await _studentService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            _logger.LogInformation("GetById method worked");

            return Ok(await _studentService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] StudentCreateDto request)
        {
            await _studentService.CreateAsync(request);
            return CreatedAtAction(nameof(Create), new { Response = "Data succesfully created" });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var student = await _studentService.GetById((int)id);

            if (student is null)
            {
                throw new ArgumentNullException();
            }

            await _studentService.DeleteAsync(id);

            return Ok();
        }
    }
}
