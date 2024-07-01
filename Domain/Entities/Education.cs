using Domain.Common;

namespace Domain.Entities
{
    public class Education : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<CGroup> Groups { get; set; }
    }
}
