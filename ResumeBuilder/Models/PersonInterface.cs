using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeBuilder.Models
{
    // Interface to Implement all Add, Update, Delete to the Server/Database.
    public interface PersonInterface
    {
        // To Fetch Single Person Details to Database.
        Person fetchDetails(int pId);

        // To get all List from Database.
        IEnumerable<Person> PersonDetails();

        // Add a Person to the Database.
        Person Add(Person person);

        // Delete a Person from the Database.
        Person Delete(int Id);

        // Update Some Details to the Database (Edit Process).
        Person Update(Person personChange);
    }
}
