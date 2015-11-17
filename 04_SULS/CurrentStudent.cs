using System;

class CurrentStudent:Student
{
    private string currentCourse;

    public CurrentStudent(string firstName, string lastName, int age, double avgGrade,
        string studentNumber, string currentCourse)
        :base(firstName, lastName, age, avgGrade, studentNumber)
    {
        this.CurrentCourse = currentCourse; 
    }

    public override string ToString()
    {
        return base.ToString()+" Current course: "+this.CurrentCourse;
    }

    public string CurrentCourse 
    { 
        get
        {
            return this.currentCourse;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Current course cannot be null, empty or whitespace-only string");
            }
            this.currentCourse = value;
        }
    }

}
