using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Define a class Person and the classes Trainer, Student. There are two types of trainers – 
 * Junior and Senior Trainer. There are three types of Students – Graduate, Current and Dropout Student. There are two types of Current Students – Online and Onsite Student. Implement the given structure below. A class down in the hierarchy should implement the fields, properties and methods of the classes above it. (Tip: Use Inheritance to achieve code reusability). The classes should implement the following fields/methods:
 * Person – fields first name, last name, age
 * Trainer – method CreateCourse([courseName]) that prints that the course has been created
 * Senior Trainer – method DeleteCourse([courseName]) that prints that the course has been deleted
 * Student – fields student number, average grade
 * Current Student – field current course
 * Onsite Student – field number of visits
 * Dropout Student – field dropout reason, method Reapply() that prints all information 
 * about the student and the dropout reason
 * Write a class SULSTest that tests the implemented class structure. 
 * Create a list of objects from each class. Extract only the Current Students, 
 * sort them by average grade and print information about each one on the console.
*/

class SULSTest
{
    static void Main()
    {
        List<Person> persons = new List<Person>();
        persons.Add(new Student("Ivan", "Ivanov", 22, 5.06, "00123456"));
        persons.Add(new Person("Dimiter", "Dimitrov", 18));
        persons.Add(new CurrentStudent("Dimiter", "Ivanov", 22, 5.6, "01123456","OOP"));
        persons.Add(new CurrentStudent("Dragan", "Draganov", 28, 4.6, "10123456", "HQC"));
        persons.Add(new DropoutStudent("Dragan", "Draganov", 42, 5.62, "10123456", DropoutReasonEnum.MissedClasses));
        persons.Add(new Trainer("Junior", "Trainer", 77));
        persons.Add(new SeniorTrainer("Senior", "Trainer", 17));
        persons.Add(new CurrentStudent("Dragan", "Milanov", 28, 5.86, "20123456", "C# Advanced"));
        
        IEnumerable<CurrentStudent> currentStudents =
            persons
            .OfType<CurrentStudent>()
            .OrderByDescending(currentStudent => currentStudent.AvgGrade);

        foreach (CurrentStudent currentStudent in currentStudents)
        {
            Console.WriteLine(currentStudent);
        }
            

    }
}