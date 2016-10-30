using System;
using System.ComponentModel.DataAnnotations;

namespace University.Data.Models
{
    /// <summary>
    /// *One-to-many relationship with Students and Courses
    /// *Fields: Content, TimeSent
    /// </summary>
    public class Homework
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(30)]
        public string Content { get; set; }

        public DateTime TimeSent { get; set; }

        public virtual Student Student { get; set; }

        public int StudentID { get; set; }

        public virtual Course Course { get; set; }

        public int CourseID { get; set; }
               
    }
}
