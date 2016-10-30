using System.Data.Entity;
using University.Data.Models;

namespace University.DataModels
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext() : base("UniversityDb")
        {
        }

        public virtual IDbSet<Student> Students { get; set; }
        public virtual IDbSet<Course> Courses { get; set; }
        public virtual IDbSet<Homework> Homeworks { get; set; }
        public virtual IDbSet<Material> Materials { get; set; }
    }
}
