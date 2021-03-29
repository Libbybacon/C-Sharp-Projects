using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionAssignment
{
    class Employee : Person
    {
        //Chain two constructors together
        public Employee(string firstName, string lastName) : this(firstName, lastName, 000)
        {
        }
        public Employee(string firstName, string lastName, int id)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
        }

        //Employee properties:
        public int ID { get; set; }
    }
}
