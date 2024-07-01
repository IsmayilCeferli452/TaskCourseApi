using Domain.Common;

namespace Domain.Entities
{
    public class TeacherGroups : BaseEntity
    {
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
        public CGroup Group { get; set; }
        public int GroupId { get; set; }
    }
}
