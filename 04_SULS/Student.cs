using System;


class Student:Person
{
    private double avgGrade;
    private string studentNumber;
    public Student(string firstName, string lastName, int age, double avgGrade, string studentNumber)
        : base(firstName, lastName, age)
    {
        this.AvgGrade = avgGrade;
        this.StudentNumber = studentNumber;
    }

    public override string ToString()
    {
        return base.ToString()+string.Format(" Student number: {0} Average Grade: {1:F}", this.StudentNumber, this.AvgGrade);
    }

    public double AvgGrade 
    {
        get
        {
            return this.avgGrade;
        }
        set
        {
            if (value < 2.0 || value > 6.0)
            {
                throw new ArgumentOutOfRangeException("Average grade must be in range [2.0 - 6.0]");
            }
            this.avgGrade = value;
        }
    }

    public string StudentNumber 
    {
        get
        {
            return this.studentNumber;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Student number cannot be null, empty or whitespace-only string");
            }
            this.studentNumber = value;
        }
    }


}