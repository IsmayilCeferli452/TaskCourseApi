using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
namespace Repository.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<CGroup> Groups { get; set; }
        public DbSet<StudentGroups> StudentGroups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherGroups> TeacherGroups { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Education> Educations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
