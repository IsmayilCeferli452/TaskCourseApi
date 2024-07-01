using Domain.Common;

namespace Domain.Entities
{
    //Entity adi Group olanda sistemde bezen error verir
    public class CGroup : BaseEntity
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int RoomId { get; set; }
        public int EducationId { get; set; }
        public ICollection<StudentGroups> StudentGroups { get; set; }
        public ICollection<TeacherGroups> TeacherGroups { get; set; }
    }
}
