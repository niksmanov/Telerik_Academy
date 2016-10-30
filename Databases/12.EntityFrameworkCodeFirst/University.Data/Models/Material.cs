using System.ComponentModel.DataAnnotations;

namespace University.Data.Models
{
    /// <summary>
    /// *One-to-many relationship with Courses
    /// </summary>
    public class Material
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public int CourseID { get; set; }

        public Course Course { get; set; }
    }
}
