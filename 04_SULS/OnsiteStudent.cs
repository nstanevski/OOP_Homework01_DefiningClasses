using System;



class OnsiteStudent:CurrentStudent
{
    private int numVisits;

    public OnsiteStudent(string firstName, string lastName, int age, double avgGrade,
        string studentNumber, string currentCourse, int numVisits)
        : base(firstName, lastName, age, avgGrade, studentNumber, currentCourse)
    {
        this.NumVisits = numVisits;
    }

    public int NumVisits
    {
        get
        {
            return this.numVisits;
        }
        set
        {
            if (value < 0 || value > 1000)
            {
                throw new ArgumentOutOfRangeException("Number of visits is positive, less than 1000");
            }
            this.numVisits = value;
        }
    }
}