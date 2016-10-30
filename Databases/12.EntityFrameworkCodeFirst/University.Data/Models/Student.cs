using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace University.Data.Models
{
    /// <summary>
    /// *Fields: Id, Name, Number
    /// *Many-to-many relationship with Courses
    /// *One-to-many relationship with Homeworks
    /// </summary>
    public class Student
    {
        private ICollection<Homework> homeworks;
        private ICollection<Course> courses;

        public Student()
        {
            this.homeworks = new HashSet<Homework>();
            this.courses = new HashSet<Course>();
        }

        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(40)]
        public string FullName { get; set; }

        [Required]
        public int StudentNumber { get; set; }

        public virtual ICollection<Homework> Homeworks
        {
            get { return this.homeworks; }
            set { this.homeworks = value; }
        }

        public virtual ICollection<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }
    }
}
