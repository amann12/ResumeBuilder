using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeBuilder.Models
{
    public class SqlRepo:PersonInterface
    {
        private readonly AppDbContext context;

        public SqlRepo(AppDbContext context)
        {
            this.context = context;
        }

        // Method to Add a Person to Database.
        public Person Add(Person person)
        {
            context.Person.Add(person);
            context.SaveChanges();
            return person;
        }

        // Deleting a Person Profile from Database.
        public Person Delete(int Id)
        {
            Person person = context.Person.Find(Id);
            if(person != null)
            {
                context.Person.Remove(person);
                context.SaveChanges();

            }
            return person;
        }

        // This Method Fetched details of a Single Person from Database.
        public Person fetchDetails(int pId)
        {
            return context.Person.Find(pId);
        }
        // This Method Fetched details of All Person from Database.
        // This IEnumerable fetches all List form Database.
        public IEnumerable<Person> PersonDetails()
        {
            return context.Person;
        }

        // This method helps users to edit the users data in Database.
        public Person Update(Person personChange)
        {
            var person = context.Person.Attach(personChange);
            person.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return personChange;
        }
    }
}
