using Microsoft.EntityFrameworkCore;

namespace SEMANA13.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAB1504-03\\SQLEXPRESS; " +
                "Initial Catalog=SchoolDB; Integrated Security=True;trustservercertificate=True");
        }

        public DbSet<SEMANA13.Models.Course> Course { get; set; } = default!;

        public DbSet<SEMANA13.Models.Enrollment> Enrollment { get; set; } = default!;
    }

}

