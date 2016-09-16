using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    internal class StartUp
    {
        internal static void Main()
        {
            var studentsList = new List<Student>
            {
                new Student("Pesho", "Peshov", 3),
                new Student("Ivan", "Peshov", 2),
                new Student("Pesho", "Ivanov", 11),
                new Student("Joro", "Jorov", 1),
                new Student("Zesho", "Keshov", 2),
                new Student("Sesho", "Seshov", 10),
                new Student("Gesho", "Ueshov", 12),
                new Student("Vesho", "Eshov", 8),
                new Student("Yesho", "Leshov", 6),
                new Student("Resho", "Jekov", 8)
            };

            //var sortedStudentList =
            //    from s in studentsList
            //    orderby s.Grade
            //    select s;

            var sortedStudentList =
                studentsList.OrderBy(s => s.Grade);

            foreach (var student in sortedStudentList)
            {
                Console.WriteLine("Student: {0} {1} Grade: {2}",
                    student.FirstName, student.LastName, student.Grade);
            }


            var workersList = new List<Worker>
            {
                new Worker("Pesho", "Peshov", 400, 4),
                new Worker("Ivan", "Peshov", 200, 6),
                new Worker("Pesho", "Ivanov", 300, 8),
                new Worker("Joro", "Jorov", 600, 3),
                new Worker("Zesho", "Keshov", 1000, 2),
                new Worker("Sesho", "Seshov", 100, 5),
                new Worker("Gesho", "Ueshov", 400, 3),
                new Worker("Vesho", "Eshov", 150, 8),
                new Worker("Yesho", "Leshov", 300, 2),
                new Worker("Resho", "Jekov", 250, 7)
            };

            var sortedWorkersList =
                workersList.OrderByDescending(w => w.MoneyPerHour());

            foreach (var worker in sortedWorkersList)
            {
                Console.WriteLine("Worker: {0} {1} Money per hour: {2}",
                    worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }

            var humans = new List<Human>();
            humans.AddRange(studentsList);
            humans.AddRange(workersList);

            var mergedLists =
                from h in humans
                orderby h.FirstName ascending,
                h.LastName ascending
                select h;

            foreach (var human in mergedLists)
            {
                Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
            }
        }
    }
}
