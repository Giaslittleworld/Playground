using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundLibrary.Models
{
    public class PersonModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public PersonModel(int id, string firstName, string lastName) 
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            FullName = $" { FirstName } { LastName } ";
        }

     }
}
