using System;



class Person
{
    private string firstName;
    private string lastName;
    private int age;

    public Person(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public override string ToString()
    {
        return string.Format("Name: {0} {1} Age: {2:D}", FirstName, LastName, Age);
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("First name cannot be null, empty or whitespace-only");
            }
            this.firstName = value;
        }
    }

    public string LastName 
    { 
        get
        {
            return this.lastName;
        }
        set
        {
            if(string.IsNullOrWhiteSpace(value)){
                throw new ArgumentException("Last name cannot be null, empty or whitespace-only");
            }
            this.lastName = value;
        }
       
    }

    public int Age 
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 15 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Age must be in range [15-100]");
            }
            this.age = value;
        }
    }
}