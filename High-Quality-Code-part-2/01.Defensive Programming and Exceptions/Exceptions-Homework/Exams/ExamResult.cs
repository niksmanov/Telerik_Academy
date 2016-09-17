using System;

public class ExamResult
{
        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new IndexOutOfRangeException("Exam results cannot be less than 0!");
        }

        if (minGrade < 0)
        {
            throw new IndexOutOfRangeException("Minimal results cannot be less than 0!");
        }

        if (maxGrade <= minGrade)
        {
            throw new IndexOutOfRangeException("Maximal exam results cannot be less than minimal results!");
        }

        if (comments == null || comments == string.Empty)
        {
            throw new ArgumentNullException("Comments cannot be null or empty!");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade { get; private set; }

    public int MinGrade { get; private set; }

    public int MaxGrade { get; private set; }

    public string Comments { get; private set; }
}
