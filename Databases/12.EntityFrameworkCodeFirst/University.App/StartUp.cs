using System;
using System.Data.Entity;
using University.Data.Models;
using University.DataModels;
using University.DataModels.Migrations;
using System.Linq;

namespace University.App
{
    public class StartUp
    {
        public static void Main()
        {
            var dbContext = new DataModels.UniversityDbContext();

            var firstStudent = new Student()
            {
                FullName = "Pesho Peshov",
                StudentNumber = 1234
            };

            var secondStudent = new Student()
            {
                FullName = "Ivan Ivanov",
                StudentNumber = 5475
            };

            dbContext.Students.Add(firstStudent);
            dbContext.Students.Add(secondStudent);

            var course = new Course()
            {
                Description = "some course",
                Name = "Biology",
            };

            dbContext.Courses.Add(course);

            var homework = new Homework()
            {
                Course = course,
                Student = firstStudent,
                Content = "some content",
                TimeSent = new DateTime(2016, 10, 30)
            };

            dbContext.Homeworks.Add(homework);
            dbContext.SaveChanges();
                       
            var students = dbContext.Students.Select(s => s.FullName).ToList();
            var courses = dbContext.Courses.Select(c => c.Name).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, students));
            Console.WriteLine(string.Join(Environment.NewLine, courses));

        }
    }
}
