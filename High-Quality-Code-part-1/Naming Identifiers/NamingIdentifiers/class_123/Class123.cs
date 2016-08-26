namespace Homework
{
    using System;

    internal class Students
    {
        private const int MaxCount = 6;

        internal static void Main()
        {
            Students.InMathClass newStudent = new Students.InMathClass();
            newStudent.CheckIfStudentIsInClass(true);
        }

        internal class InMathClass
        {
            internal void CheckIfStudentIsInClass(bool studentsChecker)
            {
                string result = studentsChecker.ToString();
                Console.WriteLine(result);
            }
        }
    }
}
