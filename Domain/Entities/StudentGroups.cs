using Domain.Common;

namespace Domain.Entities
{
    public class StudentGroups : BaseEntity
    {
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public CGroup Group { get; set; }
        public int GroupId { get; set; }
    }
}
