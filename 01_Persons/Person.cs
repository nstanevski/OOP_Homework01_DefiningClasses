using System;

namespace Persons
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age):this(name, age, null)
        {
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Age: {1}, Email: {2}", this.name, this.age, this.email);
        }

       
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Name cannot be null or empty");
                this.name = value;
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
                if (value < 1 || value > 100)
                    throw new ArgumentOutOfRangeException("Age must be a value in range [1...100]");
                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if ((value != null) && (value.IndexOf('@') == -1))
                    throw new ArgumentException(@"Argument must be either null or a string containing '@'");
                this.email = value;
            }
        }
    }
}
