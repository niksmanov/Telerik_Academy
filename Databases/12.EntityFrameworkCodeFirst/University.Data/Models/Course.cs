using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace University.Data.Models
{
    /// <summary>
    /// *Fields: Name, Description, Materials
    /// *Many-to-many relationship with Students
    /// *One-to-many relationship with Homeworks
    /// *One-to-many relationship with Materials
    /// </summary>
    public class Course
    {
        private ICollection<Student> students;
        private ICollection<Material> materials;
        private ICollection<Homework> homeworks;

        public Course()
        {
            this.students = new HashSet<Student>();
            this.materials = new HashSet<Material>();
            this.homeworks = new HashSet<Homework>();
        }

        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        public virtual ICollection<Material> Materials
        {
            get { return this.materials; }
            set { this.materials = value; }
        }

        public virtual ICollection<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get { return this.homeworks; }
            set { this.homeworks = value; }
        }
    }
}
