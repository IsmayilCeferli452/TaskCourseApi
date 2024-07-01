namespace Service.DTOs.Admin.Student
{
    public class StudentCreateDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public ICollection<int> GroupIds { get; set; }
    }
}
