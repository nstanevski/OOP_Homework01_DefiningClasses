using System;



class DropoutStudent:Student
{
    private DropoutReasonEnum dropoutReason;

    public DropoutStudent(string firstName, string lastName, int age, double avgGrade, 
        string studentNumber, DropoutReasonEnum dropoutReason)
        :base(firstName, lastName, age, avgGrade, studentNumber)
    {
        this.DropoutReason = dropoutReason;
    }

    public DropoutReasonEnum DropoutReason 
    {
        get
        {
            return this.dropoutReason;
        }
        set
        {
            this.dropoutReason = value;
        }
    }
}