using System;
using System.Collections.Generic;

/*
 * Define a class Person that has name, age and email. The name and age are mandatory. 
 * The email is optional. Define properties that accept non-empty name and age 
 * in the range [1 ... 100]. In case of invalid arguments, throw an exception. 
 * Define a property for the email that accepts either null or non-empty string 
 * containing '@'. Define two constructors. The first constructor should take name, age and email. 
 * The second constructor should take name and age only and call the first constructor. 
 * Implement the ToString() method to enable printing persons at the console.
 */

namespace Persons
{
    class Persons
    {
        static void Main()
        {
            List<Person> persons = new List<Person>();
            try
            {
                //Commented lines below contain invalid data. You can uncomment them
                //in order to see how data validation is done

                persons.Add(new Person("Ivan", 19, "ivan2@ivan.com"));
                persons.Add(new Person("Vanko2", 29));
                //persons.Add(new Person("Dragan", 129));
                //persons.Add(new Person("Iliyan", 33, "invalidEmail"));
                //persons.Add(new Person("Peter", 0, "peter@baby.com"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot create person object: " + ex.Message);
            }
            
            foreach (Person p in persons)
            {
                Console.WriteLine(p);
            }

        }
    }
}
